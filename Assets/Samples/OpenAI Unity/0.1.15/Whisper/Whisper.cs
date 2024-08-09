using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.IO;
using Amazon;
using Amazon.Polly;
using Amazon.Polly.Model;
using Amazon.Runtime;
using UnityEngine.Networking;
using System.Threading.Tasks;
using System;
using TMPro;
using UnityEngine.Video;
using OpenAI.Chat;
using OpenAI.Models;
using OpenAI.Audio;

namespace OpenAI
{
    public class Whisper : MonoBehaviour
    {
        //whisper script SerializeField
        [SerializeField] private Button recordButton;
        [SerializeField] private Image progressBar;
        [SerializeField] public Text message;
        [SerializeField] private Dropdown dropdown;

        //chatgpt script SerializeField
        [SerializeField] private InputField inputField;
        [SerializeField] private Button button;
        [SerializeField] private ScrollRect scroll;
        [SerializeField] private RectTransform sent;
        [SerializeField] private RectTransform received;

        //polly script SerializeField
        [SerializeField] private AudioSource audioSource;
        [SerializeField] private Dropdown dropdownLanguage;
        // [SerializeField] private Button ttsbutton;                                                   //Removed to avoid another button to listen
        
        //whisper script variables
        private readonly string fileName = "output.wav";
        private readonly int duration = 5;
        
        private AudioClip clip;
        private bool isRecording;
        private float time;
        // private OpenAIClient openai = new OpenAIClient("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");

        //chatgpt script variables
        private float height;
        private List<Message> messages = new List<Message>();
        private string prompt = "You are an assistant that is serious. Your mission is to provide information about kitchen safety. Don't break character. Provide answers in less than three sentences.";

        
        //polly script variables
        private string messageContent;
        private string[] languagesList = {"English", "Spanish", "Italian", "French", "Greek" };                                                    //add Languages here
        private string currentLanguage;
        // private string currentVoice;
        private VoiceId voiceIdBySelection;
        
        


        // whisper script functions
        private void Start()
        {
            OpenAIClient api = new OpenAIClient(new OpenAIAuthentication().LoadFromDirectory("./Assets/Resources"));
            /*#if UNITY_WEBGL && !UNITY_EDITOR
            dropdown.options.Add(new Dropdown.OptionData("Microphone not supported on WebGL"));
            #else*/
            foreach (var device in Microphone.devices)
            {
                dropdown.options.Add(new Dropdown.OptionData(device));
            }

            //add language selection here
            foreach (var lang in languagesList)
            {
                dropdownLanguage.options.Add(new Dropdown.OptionData(lang));
            }
            dropdownLanguage.onValueChanged.AddListener(selectLanguage);
            recordButton.onClick.AddListener(StartRecording);
            dropdown.onValueChanged.AddListener(ChangeMicrophone);
            
            var index = PlayerPrefs.GetInt("user-mic-device-index");
            dropdown.SetValueWithoutNotify(index);
            button.onClick.AddListener(delegate{SendReply(api);});                                  //this button is the send button for chatgpt script
            //#endif
        }

        
        private void ChangeMicrophone(int index)
        {
            PlayerPrefs.SetInt("user-mic-device-index", index);
        }
        
        private void StartRecording()
        {
            isRecording = true;
            recordButton.enabled = false;

            var index = PlayerPrefs.GetInt("user-mic-device-index");
            
            #if !UNITY_WEBGL
            clip = Microphone.Start(dropdown.options[index].text, false, duration, 44100);
            #endif
        }

        private async void EndRecording(OpenAIClient api)
        {
            message.text = "Transcripting...";
            
            #if !UNITY_WEBGL
            Microphone.End(null);
            #endif
            
            byte[] data = SaveWav.Save(fileName, clip);
            
            // var req = new CreateAudioTranscriptionsRequest
            // {
            //     FileData = new FileData() {Data = data, Name = "audio.wav"},
            //     // File = Application.persistentDataPath + "/" + fileName,
            //     Model = "whisper-1",
            //     Language = currentLanguage
            // };
            // var res = await openai.CreateAudioTranscription(req);
            var request = new AudioTranscriptionRequest(clip, language: currentLanguage);
            var result = await api.AudioEndpoint.CreateTranscriptionAsync(request);
            

            progressBar.fillAmount = 0;
            message.text = result;
            // message.text = "Hi, how are you?";
            recordButton.enabled = true;
        }

        private void Update()
        {
            OpenAIClient api = new OpenAIClient(new OpenAIAuthentication().LoadFromDirectory("./Assets/Resources"));
            if (isRecording)
            {
                time += Time.deltaTime;
                progressBar.fillAmount = time / duration;
                
                if (time >= duration)
                {
                    time = 0;
                    isRecording = false;
                    EndRecording(api);
                }
            }
        }


        //chatgpt script functions
        private void AppendMessage(Message message)
        {
            scroll.content.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 0);

            
            var item = Instantiate(message.Role == Role.User ? sent : received, scroll.content);
            item.GetChild(0).GetChild(0).GetComponent<Text>().text = (string)message.Content;
            item.anchoredPosition = new Vector2(0, -height);
            LayoutRebuilder.ForceRebuildLayoutImmediate(item);
            height += item.sizeDelta.y;
            scroll.content.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, height);
            scroll.verticalNormalizedPosition = 0;
            
        }

        private async void SendReply(OpenAIClient api)
        {
            if (messages.Count == 0){
                Message newMessage = new Message(Role.User, prompt + message.text);                //replace with prompt + message.text
                messages.Add(newMessage);
                Message newMessageForDisplay = new Message(Role.User, message.text);
                AppendMessage(newMessageForDisplay);
                
            }
            else{

                Message newMessage = new Message(Role.User, message.text);                //replace with message.text
                AppendMessage(newMessage);                   
                messages.Add(newMessage);
            }
            
            
            button.enabled = false;
            inputField.text = "";
            inputField.enabled = false;
            
            // Complete the instruction
            
            // var completionResponse = await openai.CreateChatCompletion(new CreateChatCompletionRequest()
            // {
            //     Model = "gpt-3.5-turbo-0613",
            //     Messages = messages
            // });

            // if (completionResponse.Choices != null && completionResponse.Choices.Count > 0)
            // {
            //     var message = completionResponse.Choices[0].Message;
            //     message.Content = message.Content.Trim();
            //     messageContent = message.Content;
            var chatRequest = new ChatRequest(messages, Model.GPT3_5_Turbo);
            var response = await api.ChatEndpoint.GetCompletionAsync(chatRequest);
            var choice = response.FirstChoice.Message;
            
                
                messages.Add(choice);
                AppendMessage(choice);
            // }
            // else
            // {
            //     Debug.LogWarning("No text was generated from this prompt.");
            // }


            //tts
            var credentials = new BasicAWSCredentials("AKIAQ4HNHK2SDU7JOT4U", "Ni9WUYMCSNvMlj29SUmrQGxvCBkMbuRWUTnZ+O8Y"); 
            var client = new AmazonPollyClient(credentials, RegionEndpoint.USEast1);

            if (currentLanguage == "en"){

                voiceIdBySelection = VoiceId.Joanna;
            }

            if (currentLanguage == "es"){

                voiceIdBySelection = VoiceId.Lupe;
            }

            if (currentLanguage == "it")
            {

                voiceIdBySelection = VoiceId.Giorgio;
            }

            if (currentLanguage == "fr")
            {

                voiceIdBySelection = VoiceId.Mathieu;
            }

            if (currentLanguage == "el")
            {
                button.enabled = true;
                inputField.enabled = true;
                return;
            }

            var request = new SynthesizeSpeechRequest(){

                Text = (string)choice.Content,
                // Text = "This is a dummy test",
                // Engine = Engine.Standard,
                Engine = Engine.Neural,
                VoiceId = voiceIdBySelection,
                OutputFormat = OutputFormat.Mp3
            };

            var responseVoice = await client.SynthesizeSpeechAsync(request);

            WriteIntoFile(responseVoice.AudioStream);

            using (var www = UnityWebRequestMultimedia.GetAudioClip($"file://{Application.persistentDataPath}/ttsGeneratedAudio.mp3", AudioType.MPEG))
            {

                var op = www.SendWebRequest();

                while(!op.isDone) await Task.Yield();

                var clip = DownloadHandlerAudioClip.GetContent(www);

                audioSource.clip = clip;
                audioSource.Play();
            }
            Console.WriteLine(messageContent);

            button.enabled = true;
            inputField.enabled = true;
        }

    
        //tts Polly functions

        private void WriteIntoFile(Stream stream){

            using (var fileStream = new FileStream($"{Application.persistentDataPath}/ttsGeneratedAudio.mp3", FileMode.Create)){

                byte[] buffer = new byte[8 * 1024];
                int bytesRead;

                while((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0){

                    fileStream.Write(buffer, 0, bytesRead);
                }

            }
        }


        private void selectLanguage(int index){
            
            if (index == 1){

                currentLanguage = "en";
            }

            if (index == 2){

                currentLanguage = "es";
            }

            if (index == 3)
            {

                currentLanguage = "it";
            }

            if (index == 4)
            {

                currentLanguage = "fr";
            }

            if (index == 5)
            {

                currentLanguage = "el";
            }
        }

        public void OnClickCloseBtn()
        {
            Microphone.End(null);
            isRecording = false;
            time = 0;
            recordButton.enabled = true;
            progressBar.fillAmount = 0;
            audioSource.Stop();
            gameObject.SetActive(false);
        }



        //DEPRECATED FUNCTIONS


        //Sends content to Polly and awaits a response as a tts. This function has been added to SendReply()
        // private async void SendAudio(){

        //     System.Threading.Thread.Sleep(3000);            
        //     var credentials = new BasicAWSCredentials("AKIAQ4HNHK2SDU7JOT4U", "Ni9WUYMCSNvMlj29SUmrQGxvCBkMbuRWUTnZ+O8Y"); 
        //     var client = new AmazonPollyClient(credentials, RegionEndpoint.USEast1);

        //     var request = new SynthesizeSpeechRequest(){

        //         Text = messageContent,
        //         Engine = Engine.Standard,
        //         VoiceId = VoiceId.Lupe,
        //         OutputFormat = OutputFormat.Mp3
        //     };

        //     var response = await client.SynthesizeSpeechAsync(request);

        //     WriteIntoFile(response.AudioStream);

        //     using (var www = UnityWebRequestMultimedia.GetAudioClip($"{Application.persistentDataPath}/ttsGeneratedAudio.mp3", AudioType.MPEG))
        //     {

        //         var op = www.SendWebRequest();

        //         while(!op.isDone) await Task.Yield();

        //         var clip = DownloadHandlerAudioClip.GetContent(www);

        //         audioSource.clip = clip;
        //         audioSource.Play();
        //     }
        //     Console.WriteLine(messageContent);
        // }

    }



//     public class ChatGPT : MonoBehaviour
//     {
//         [SerializeField] private InputField inputField;
//         [SerializeField] private Button button;
//         [SerializeField] private ScrollRect scroll;
        
//         [SerializeField] private RectTransform sent;
//         [SerializeField] private RectTransform received;

//         private float height;
//         private OpenAIApi openai = new OpenAIApi("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");

//         private List<ChatMessage> messages = new List<ChatMessage>();
//         private string prompt = "You are an AI chatbot that is serious. Your mission is to provide information about kitchen safety. Don't break character.";

//         public Whisper whisperObject = new Whisper();
//         public string whisperMessage => whisperObject.getMessage();

//         private void Start()
//         {
//             button.onClick.AddListener(SendReply);
//         }

//         private void AppendMessage(ChatMessage message)
//         {
//             scroll.content.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 0);

//             var item = Instantiate(message.Role == "user" ? sent : received, scroll.content);
//             item.GetChild(0).GetChild(0).GetComponent<Text>().text = message.Content;
//             item.anchoredPosition = new Vector2(0, -height);
//             LayoutRebuilder.ForceRebuildLayoutImmediate(item);
//             height += item.sizeDelta.y;
//             scroll.content.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, height);
//             scroll.verticalNormalizedPosition = 0;
//         }

//         private async void SendReply()
//         {
//             var newMessage = new ChatMessage()
//             {
//                 Role = "user",
//                 // Content = inputField.text
//                 Content = whisperMessage
//             };
            
//             AppendMessage(newMessage);

//             if (messages.Count == 0) newMessage.Content = prompt + "\n" + whisperMessage; 
            
//             messages.Add(newMessage);
            
//             button.enabled = false;
//             inputField.text = "";
//             inputField.enabled = false;
            
//             // Complete the instruction
//             var completionResponse = await openai.CreateChatCompletion(new CreateChatCompletionRequest()
//             {
//                 Model = "gpt-3.5-turbo-0613",
//                 Messages = messages
//             });

//             if (completionResponse.Choices != null && completionResponse.Choices.Count > 0)
//             {
//                 var message = completionResponse.Choices[0].Message;
//                 message.Content = message.Content.Trim();
                
//                 messages.Add(message);
//                 AppendMessage(message);
//             }
//             else
//             {
//                 Debug.LogWarning("No text was generated from this prompt.");
//             }

//             button.enabled = true;
//             inputField.enabled = true;
//         }
//     }
}