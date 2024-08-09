//Maya ASCII 2023 scene
//Name: onion.ma
//Last modified: Wed, Nov 01, 2023 12:30:37 PM
//Codeset: 1252
requires maya "2023";
requires -nodeType "aiOptions" -nodeType "aiAOVDriver" -nodeType "aiAOVFilter" "mtoa" "5.2.0";
currentUnit -l centimeter -a degree -t film;
fileInfo "application" "maya";
fileInfo "product" "Maya 2023";
fileInfo "version" "2023";
fileInfo "cutIdentifier" "202208031415-1dee56799d";
fileInfo "osv" "Windows 10 Pro v2009 (Build: 19045)";
fileInfo "UUID" "22A4A775-4924-51FD-218E-2781AE8F4A92";
createNode transform -s -n "persp";
	rename -uid "92E3C2EE-4600-EF3D-A53F-1092BD115AB7";
	setAttr ".v" no;
	setAttr ".t" -type "double3" 17.560892346819962 11.824781751609191 0.66632027926527904 ;
	setAttr ".r" -type "double3" -35.138352730089807 84.599999999916335 -3.3796745146729287e-14 ;
createNode camera -s -n "perspShape" -p "persp";
	rename -uid "3884223B-4DBE-25D7-647B-01A7778E4250";
	setAttr -k off ".v" no;
	setAttr ".fl" 34.999999999999993;
	setAttr ".coi" 20.179749967276784;
	setAttr ".imn" -type "string" "persp";
	setAttr ".den" -type "string" "persp_depth";
	setAttr ".man" -type "string" "persp_mask";
	setAttr ".hc" -type "string" "viewSet -p %camera";
createNode transform -s -n "top";
	rename -uid "783E873C-4A97-47BA-3231-088863DD289E";
	setAttr ".t" -type "double3" 0.48204654667487135 1000.1 0.63930438160843606 ;
	setAttr ".r" -type "double3" -90 0 0 ;
createNode camera -s -n "topShape" -p "top";
	rename -uid "8668EE4B-48B6-A593-3C57-2883622DE793";
	setAttr -k off ".v";
	setAttr ".rnd" no;
	setAttr ".coi" 1000.1;
	setAttr ".ow" 13.807589660245;
	setAttr ".imn" -type "string" "top";
	setAttr ".den" -type "string" "top_depth";
	setAttr ".man" -type "string" "top_mask";
	setAttr ".hc" -type "string" "viewSet -t %camera";
	setAttr ".o" yes;
	setAttr ".ai_translator" -type "string" "orthographic";
createNode transform -s -n "front";
	rename -uid "DC0654E3-47A5-8879-15C5-FA8F6BF1E339";
	setAttr ".v" no;
	setAttr ".t" -type "double3" -0.12431373624684428 0.11163694805688745 1000.1 ;
createNode camera -s -n "frontShape" -p "front";
	rename -uid "B7C44F58-4DE2-4BE9-4204-42B552D1F246";
	setAttr -k off ".v" no;
	setAttr ".rnd" no;
	setAttr ".coi" 1000.1;
	setAttr ".ow" 10.71502733729044;
	setAttr ".imn" -type "string" "front";
	setAttr ".den" -type "string" "front_depth";
	setAttr ".man" -type "string" "front_mask";
	setAttr ".hc" -type "string" "viewSet -f %camera";
	setAttr ".o" yes;
	setAttr ".ai_translator" -type "string" "orthographic";
createNode transform -s -n "side";
	rename -uid "533AC768-45EA-D393-4F2A-F389948B3202";
	setAttr ".v" no;
	setAttr ".t" -type "double3" 1000.1 0 0 ;
	setAttr ".r" -type "double3" 0 90 0 ;
createNode camera -s -n "sideShape" -p "side";
	rename -uid "398189F4-41AF-2D81-FAB9-B78FAA9AA570";
	setAttr -k off ".v" no;
	setAttr ".rnd" no;
	setAttr ".coi" 1000.1;
	setAttr ".ow" 30;
	setAttr ".imn" -type "string" "side";
	setAttr ".den" -type "string" "side_depth";
	setAttr ".man" -type "string" "side_mask";
	setAttr ".hc" -type "string" "viewSet -s %camera";
	setAttr ".o" yes;
	setAttr ".ai_translator" -type "string" "orthographic";
createNode transform -n "imagePlane1";
	rename -uid "39E158FB-46F2-0F8E-C263-BD95154999A7";
	setAttr ".t" -type "double3" 0 -5.8285996675626777 0 ;
	setAttr ".r" -type "double3" -90 0 0 ;
createNode imagePlane -n "imagePlaneShape1" -p "imagePlane1";
	rename -uid "8329B871-47B8-6A96-34E2-069E51581F56";
	setAttr -k off ".v";
	setAttr ".fc" 204;
	setAttr ".imn" -type "string" "D:/2.External/3d_Asset_creation/1_NOV/vegitables/cucumber/cucumber.jpg";
	setAttr ".cov" -type "short2" 612 612 ;
	setAttr ".dlc" no;
	setAttr ".w" 6.12;
	setAttr ".h" 6.12;
	setAttr ".cs" -type "string" "sRGB";
createNode transform -n "pCylinder4";
	rename -uid "75878B54-4CC8-30D5-5A1E-38824FE716E8";
	setAttr ".rp" -type "double3" 1.3395348516469359 1.5279952704302604 -1.6204968939207438 ;
	setAttr ".sp" -type "double3" 1.3395348516469359 1.5279952704302604 -1.6204968939207438 ;
createNode mesh -n "pCylinder4Shape" -p "pCylinder4";
	rename -uid "5FE0BFEA-424F-A2F2-444C-23BC19160683";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr -s 10 ".gtag";
	setAttr ".gtag[0].gtagnm" -type "string" "bottom";
	setAttr ".gtag[0].gtagcmp" -type "componentList" 6 "f[14:27]" "f[43]" "f[59:72]" "f[88]" "f[104:117]" "f[133]";
	setAttr ".gtag[1].gtagnm" -type "string" "bottomRing";
	setAttr ".gtag[1].gtagcmp" -type "componentList" 9 "e[0:12]" "e[68]" "e[72]" "e[75:87]" "e[143]" "e[147]" "e[150:162]" "e[218]" "e[222]";
	setAttr ".gtag[2].gtagnm" -type "string" "cylBottomCap";
	setAttr ".gtag[2].gtagcmp" -type "componentList" 6 "vtx[0:13]" "vtx[28]" "vtx[32:45]" "vtx[60]" "vtx[64:77]" "vtx[92]";
	setAttr ".gtag[3].gtagnm" -type "string" "cylBottomRing";
	setAttr ".gtag[3].gtagcmp" -type "componentList" 3 "vtx[0:13]" "vtx[32:45]" "vtx[64:77]";
	setAttr ".gtag[4].gtagnm" -type "string" "cylSides";
	setAttr ".gtag[4].gtagcmp" -type "componentList" 3 "vtx[0:27]" "vtx[32:59]" "vtx[64:91]";
	setAttr ".gtag[5].gtagnm" -type "string" "cylTopCap";
	setAttr ".gtag[5].gtagcmp" -type "componentList" 6 "vtx[14:27]" "vtx[29]" "vtx[46:59]" "vtx[61]" "vtx[78:91]" "vtx[93]";
	setAttr ".gtag[6].gtagnm" -type "string" "cylTopRing";
	setAttr ".gtag[6].gtagcmp" -type "componentList" 3 "vtx[14:27]" "vtx[46:59]" "vtx[78:91]";
	setAttr ".gtag[7].gtagnm" -type "string" "sides";
	setAttr ".gtag[7].gtagcmp" -type "componentList" 4 "f[0:13]" "f[44:58]" "f[89:103]" "f[134]";
	setAttr ".gtag[8].gtagnm" -type "string" "top";
	setAttr ".gtag[8].gtagcmp" -type "componentList" 3 "f[28:42]" "f[73:87]" "f[118:132]";
	setAttr ".gtag[9].gtagnm" -type "string" "topRing";
	setAttr ".gtag[9].gtagcmp" -type "componentList" 6 "e[13:25]" "e[69:70]" "e[88:100]" "e[144:145]" "e[163:175]" "e[219:220]";
	setAttr ".pv" -type "double2" 0.3002471923828125 0.43367111310362816 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 198 ".uvst[0].uvsp[0:197]" -type "float2" 0.47893494 0.66780347
		 0.42176318 0.57893741 0.33721954 0.52401191 0.23359883 0.5013954 0.11583436 0.53808081
		 0.039461434 0.61599988 -0.0061041117 0.72090471 0.0010017157 0.82558876 0.059425235
		 0.93360257 0.15187824 0.99133843 0.24695277 1.0063973665 0.42475051 0.92596155 0.47948837
		 0.84059316 0.49444532 0.75414973 0.50612742 0.86727107 0.50599182 0.81195188 0.50560981
		 0.65622449 0.50524729 0.50861818 0.50503123 0.42062348 0.50467014 0.27354345 0.50463825
		 0.15613717 0.5048427 0.083081633 0.50507545 5.3942204e-06 0.5611161 0.55701429 0.56137717
		 0.46372822 0.56146109 0.32473591 0.56125736 0.17010768 0.56114525 0.085089713 0.56103295
		 7.1160495e-05 0.55864334 0.8671425 0.55850768 0.81182295 0.55812562 0.65609539 0.5577631
		 0.50848907 0.55754715 0.42049456 0.55718607 0.27341413 0.557154 0.15628409 0.55735868
		 0.083228558 0.61045706 0.70245624 0.61086404 0.55715322 0.61112517 0.46386701 0.61120939
		 0.32467005 0.6110056 0.17004265 0.61089337 0.08502385 0.61078113 5.4445118e-06 0.4848305
		 0.16433841 0.42955697 0.079316467 0.25125733 0 0.15627933 0.015656263 0.064190984
		 0.073972464 0.0064480901 0.18235159 0 0.2870782 0.046224266 0.39169458 0.12308592
		 0.46913195 0.24107853 0.50507599 0.34455493 0.48180878 0.42875189 0.42635271 0.48536399
		 0.33712885 0.50033104 0.25068682 0.24184334 0.75495762 0.24772829 0.2514666 0.3446078
		 0.021087378 0.6113168 0.39536077 0.56155396 0.39498767 0.34016615 0.98379385 0.56070912
		 0.70231682 0.55759126 0.00015252829 0.50612742 0.86727107 0.50599182 0.81195188 0.55850768
		 0.81182295 0.55864334 0.8671425 0.50560981 0.65622449 0.55812562 0.65609539 0.50524729
		 0.50861818 0.5577631 0.50848907 0.50503123 0.42062348 0.55754715 0.42049456 0.50467014
		 0.27354345 0.55718607 0.27341413 0.557154 0.15628409 0.50463825 0.15613717 0.5048427
		 0.083081633 0.55735868 0.083228558 0.50507545 5.3942204e-06 0.55759126 0.00015252829
		 0.61045706 0.70245624 0.56070912 0.70231682 0.5611161 0.55701429 0.61086404 0.55715322
		 0.56137717 0.46372822 0.61112517 0.46386701 0.56155396 0.39498767 0.6113168 0.39536077
		 0.61120939 0.32467005 0.56146109 0.32473591 0.56125736 0.17010768 0.6110056 0.17004265
		 0.56114525 0.085089713 0.61089337 0.08502385 0.56103295 7.1160495e-05 0.61078113
		 5.4445118e-06 0.42176318 0.57893741 0.47893494 0.66780347 0.24184334 0.75495762 0.33721954
		 0.52401191 0.23359883 0.5013954 0.11583436 0.53808081 0.039461434 0.61599988 -0.0061041117
		 0.72090471 0.0010017157 0.82558876 0.059425235 0.93360257 0.15187824 0.99133843 0.24695277
		 1.0063973665 0.34016615 0.98379385 0.47948837 0.84059316 0.42475051 0.92596155 0.49444532
		 0.75414973 0.48536399 0.33712885 0.42875189 0.42635271 0.24772829 0.2514666 0.34455493
		 0.48180878 0.24107853 0.50507599 0.12308592 0.46913195 0.046224266 0.39169458 0 0.2870782
		 0.0064480901 0.18235159 0.064190984 0.073972464 0.15627933 0.015656263 0.25125733
		 0 0.3446078 0.021087378 0.42955697 0.079316467 0.4848305 0.16433841 0.50033104 0.25068682
		 0.50612742 0.86727107 0.50599182 0.81195188 0.55850768 0.81182295 0.55864334 0.8671425
		 0.50560981 0.65622449 0.55812562 0.65609539 0.50524729 0.50861818 0.5577631 0.50848907
		 0.50503123 0.42062348 0.55754715 0.42049456 0.50467014 0.27354345 0.55718607 0.27341413
		 0.557154 0.15628409 0.50463825 0.15613717 0.5048427 0.083081633 0.55735868 0.083228558
		 0.50507545 5.3942204e-06 0.55759126 0.00015252829 0.61045706 0.70245624 0.56070912
		 0.70231682 0.5611161 0.55701429 0.61086404 0.55715322 0.56137717 0.46372822 0.61112517
		 0.46386701 0.56155396 0.39498767 0.6113168 0.39536077 0.61120939 0.32467005 0.56146109
		 0.32473591 0.56125736 0.17010768 0.6110056 0.17004265 0.56114525 0.085089713 0.61089337
		 0.08502385 0.56103295 7.1160495e-05 0.61078113 5.4445118e-06 0.42176318 0.57893741
		 0.47893494 0.66780347 0.24184334 0.75495762 0.33721954 0.52401191 0.23359883 0.5013954
		 0.11583436 0.53808081 0.039461434 0.61599988 -0.0061041117 0.72090471 0.0010017157
		 0.82558876 0.059425235 0.93360257 0.15187824 0.99133843 0.24695277 1.0063973665 0.34016615
		 0.98379385 0.47948837 0.84059316 0.42475051 0.92596155 0.49444532 0.75414973 0.48536399
		 0.33712885 0.42875189 0.42635271 0.24772829 0.2514666 0.34455493 0.48180878 0.24107853
		 0.50507599 0.12308592 0.46913195 0.046224266 0.39169458 0 0.2870782 0.0064480901
		 0.18235159 0.064190984 0.073972464 0.15627933 0.015656263 0.25125733 0 0.3446078
		 0.021087378 0.42955697 0.079316467 0.4848305 0.16433841 0.50033104 0.25068682;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 32 ".pt[0:31]" -type "float3"  -0.0035603046 -1.0816071 
		-0.16723686 -0.049231768 -0.46751165 -0.085909486 -0.11002308 0.18410194 -0.0068421364 
		-0.18058908 0.83284616 0.065989971 -0.25528514 1.360926 0.11515856 -0.29895329 1.521888 
		0.11789346 -0.31985521 1.4456693 0.088061124 -0.30592036 1.0553381 0.02751869 -0.25773251 
		0.37011382 -0.064854264 -0.19145846 -0.33465436 -0.15006447 -0.12721476 -0.91080415 
		-0.2138238 -0.016649842 -1.624089 -0.27456725 0.012043953 -1.6404539 -0.26062626 
		0.014319181 -1.4332721 -0.22282185 0.28523421 -1.0698812 0.003261745 0.23956347 -0.45578557 
		0.084588647 0.17877215 0.1958313 0.16365647 0.10820615 0.84457362 0.23648787 0.033510685 
		1.372654 0.28565836 -0.010157585 1.5336171 0.28839278 -0.031059027 1.433756 0.25856003 
		-0.017123938 1.0434215 0.19801718 0.031063318 0.35819906 0.1056447 0.097336888 -0.34657004 
		0.020433664 0.16158091 -0.92272031 -0.043324232 0.27214587 -1.6360018 -0.10406911 
		0.30084014 -1.6523684 -0.090127409 0.30311441 -1.4451859 -0.052322991 -0.15277091 
		-0.03938368 -0.075406104 0.13602412 -0.05129654 0.095092684 0.22135574 -1.3654169 
		-0.086211205 -0.067523837 -1.3503687 -0.25620818;
	setAttr -s 96 ".vt[0:95]"  2.23326325 2.47741747 -0.93226606 1.66381717 2.2481916 -1.89316106
		 0.81929028 1.908234 -2.48876166 -0.21723354 1.49098957 -2.7363863 -1.39723706 1.015988469 -2.34459424
		 -2.16423035 0.7072413 -1.50643504 -2.62370443 0.52228355 -0.37601924 -2.55592799 0.54956651 0.75383359
		 -1.97456563 0.78358936 1.92138827 -1.050955296 1.15538144 2.54758763 -0.099737123 1.53828681 2.71336579
		 1.68260455 2.25575423 1.85155225 2.2332685 2.47741961 0.9322629 2.38575721 2.53880286 6.4987364e-07
		 2.026417732 2.99127579 -0.93226695 1.45696998 2.76204896 -1.89316285 0.61243951 2.42208982 -2.48876405
		 -0.42408413 2.0048453808 -2.73638463 -1.6040858 1.52984512 -2.34459376 -2.37108183 1.22109699 -1.50643444
		 -2.83055592 1.03613925 -0.37601721 -2.76277304 1.063424706 0.75383484 -2.18141389 1.29744625 1.92139053
		 -1.25780177 1.66923904 2.54759121 -0.30658287 2.052144527 2.71336794 1.4757551 2.76961088 1.85155201
		 2.026418209 2.99127579 0.93226975 2.17891049 3.052660465 -1.2997473e-06 -0.14282832 1.52094078 -4.5491156e-06
		 -0.34968114 2.034795761 6.4987364e-07 0.62720883 2.42803526 2.48271108 0.83405828 1.91417873 2.47267842
		 5.23281574 0.03777647 -4.15024137 4.6325922 0.16640469 -5.11113644 3.7424202 0.35716909 -5.70673704
		 2.64987469 0.59130234 -5.95436192 1.40609455 0.85784525 -5.56256962 0.59764671 1.031096101 -4.72441053
		 0.11333895 1.13488364 -3.59399462 0.18477869 1.11957407 -2.46414185 0.7975626 0.98825407 -1.29658711
		 1.77109218 0.77962601 -0.67038774 2.77372169 0.56476188 -0.50460958 4.65239525 0.16216096 -1.36642313
		 5.23282099 0.037775278 -2.28571248 5.39355135 0.0033306479 -3.21797466 5.34889126 0.57940513 -4.15024233
		 4.74866581 0.7080338 -5.11113834 3.85848999 0.898799 -5.70673943 2.76594448 1.13293219 -5.95436001
		 1.52216625 1.39947474 -5.56256914 0.71371603 1.57272613 -4.72441006 0.22940826 1.67651367 -3.59399271
		 0.30085444 1.66120267 -2.46414042 0.9136349 1.52988338 -1.29658484 1.88716626 1.32125497 -0.67038417
		 2.8897965 1.10639071 -0.50460744 4.768466 0.70379055 -1.36642337 5.34889126 0.57940507 -2.28570557
		 5.50962543 0.5449596 -3.21797657 2.72830153 0.57449543 -3.21797991 2.84436893 1.11612582 -3.21797466
		 3.87405753 0.89546287 -0.7352643 3.75798655 0.35383326 -0.74529696 2.58021188 0.016055778 -0.93226606
		 1.96636069 0.016055778 -1.89316106 1.055977821 0.016055778 -2.48876166 -0.061373681 0.016055778 -2.7363863
		 -1.33339334 0.016055778 -2.34459424 -2.16019654 0.016055778 -1.50643504 -2.65550017 0.016055778 -0.37601924
		 -2.58243847 0.016055778 0.75383359 -1.95574176 0.016055778 1.92138827 -0.96010876 0.016055778 2.54758763
		 0.065285064 0.016055778 2.71336579 1.98661304 0.016055778 1.85155225 2.58021736 0.016055778 0.9322629
		 2.7445972 0.016055778 6.4987364e-07 2.58021593 0.56998271 -0.93226695 1.96636248 0.56998271 -1.89316285
		 1.055975795 0.56998271 -2.48876405 -0.061375469 0.56998271 -2.73638463 -1.33339322 0.56998271 -2.34459376
		 -2.16019917 0.56998271 -1.50643444 -2.6555028 0.56998271 -0.37601721 -2.58243442 0.56998271 0.75383484
		 -1.95574093 0.56998271 1.92139053 -0.96010613 0.56998271 2.54759121 0.065288477 0.56998271 2.71336794
		 1.98661232 0.56998271 1.85155201 2.58021617 0.56998271 0.93226975 2.74459982 0.56998271 -1.2997473e-06
		 0.018833643 0.016055778 -4.5491156e-06 0.018829418 0.56998271 6.4987364e-07 1.071896791 0.56998271 2.48271108
		 1.071897388 0.016055778 2.47267842;
	setAttr -s 225 ".ed";
	setAttr ".ed[0:165]"  0 1 0 1 2 0 2 3 0 3 4 0 4 5 0 6 7 0 7 8 0 8 9 0 9 10 0
		 10 31 0 11 12 0 12 13 0 13 0 0 14 15 0 16 17 0 17 18 0 18 19 0 19 20 0 20 21 0 21 22 0
		 22 23 0 23 24 0 24 30 0 25 26 0 26 27 0 27 14 0 0 14 1 1 15 1 2 16 1 3 17 1 4 18 1
		 5 19 1 6 20 1 7 21 1 8 22 1 9 23 1 10 24 1 11 25 1 12 26 1 13 27 1 28 0 1 28 1 1
		 28 2 1 28 3 1 28 4 1 28 5 1 28 6 1 28 7 1 28 8 1 28 9 1 28 10 1 28 11 1 28 12 1 28 13 1
		 14 29 1 15 29 1 16 29 1 17 29 1 18 29 1 19 29 1 20 29 1 21 29 1 22 29 1 23 29 1 24 29 1
		 25 29 1 26 29 1 27 29 1 5 6 0 15 16 0 30 25 0 30 29 1 31 11 0 28 31 1 31 30 1 32 33 0
		 33 34 0 34 35 0 35 36 0 36 37 0 38 39 0 39 40 0 40 41 0 41 42 0 42 63 0 43 44 0 44 45 0
		 45 32 0 46 47 0 48 49 0 49 50 0 50 51 0 51 52 0 52 53 0 53 54 0 54 55 0 55 56 0 56 62 0
		 57 58 0 58 59 0 59 46 0 32 46 1 33 47 1 34 48 1 35 49 1 36 50 1 37 51 1 38 52 1 39 53 1
		 40 54 1 41 55 1 42 56 1 43 57 1 44 58 1 45 59 1 60 32 1 60 33 1 60 34 1 60 35 1 60 36 1
		 60 37 1 60 38 1 60 39 1 60 40 1 60 41 1 60 42 1 60 43 1 60 44 1 60 45 1 46 61 1 47 61 1
		 48 61 1 49 61 1 50 61 1 51 61 1 52 61 1 53 61 1 54 61 1 55 61 1 56 61 1 57 61 1 58 61 1
		 59 61 1 37 38 0 47 48 0 62 57 0 62 61 1 63 43 0 60 63 1 63 62 1 64 65 0 65 66 0 66 67 0
		 67 68 0 68 69 0 70 71 0 71 72 0 72 73 0 73 74 0 74 95 0 75 76 0 76 77 0 77 64 0 78 79 0
		 80 81 0 81 82 0;
	setAttr ".ed[166:224]" 82 83 0 83 84 0 84 85 0 85 86 0 86 87 0 87 88 0 88 94 0
		 89 90 0 90 91 0 91 78 0 64 78 1 65 79 1 66 80 1 67 81 1 68 82 1 69 83 1 70 84 1 71 85 1
		 72 86 1 73 87 1 74 88 1 75 89 1 76 90 1 77 91 1 92 64 1 92 65 1 92 66 1 92 67 1 92 68 1
		 92 69 1 92 70 1 92 71 1 92 72 1 92 73 1 92 74 1 92 75 1 92 76 1 92 77 1 78 93 1 79 93 1
		 80 93 1 81 93 1 82 93 1 83 93 1 84 93 1 85 93 1 86 93 1 87 93 1 88 93 1 89 93 1 90 93 1
		 91 93 1 69 70 0 79 80 0 94 89 0 94 93 1 95 75 0 92 95 1 95 94 1;
	setAttr -s 135 -ch 450 ".fc[0:134]" -type "polyFaces" 
		f 4 0 27 -14 -27
		mu 0 4 14 15 30 29
		f 4 -28 1 28 -70
		mu 0 4 30 15 16 31
		f 4 -29 2 29 -15
		mu 0 4 31 16 17 32
		f 4 3 30 -16 -30
		mu 0 4 17 18 33 32
		f 4 -31 4 31 -17
		mu 0 4 33 18 19 34
		f 4 -18 -32 68 32
		mu 0 4 35 34 19 20
		f 4 5 33 -19 -33
		mu 0 4 20 21 36 35
		f 4 6 34 -20 -34
		mu 0 4 21 22 65 36
		f 4 -35 7 35 -21
		mu 0 4 37 64 23 38
		f 4 8 36 -22 -36
		mu 0 4 23 24 39 38
		f 4 9 74 -23 -37
		mu 0 4 24 62 61 39
		f 4 -38 10 38 -24
		mu 0 4 40 25 26 41
		f 4 11 39 -25 -39
		mu 0 4 26 27 42 41
		f 4 12 26 -26 -40
		mu 0 4 27 28 43 42
		f 3 -1 -41 41
		mu 0 3 1 0 58
		f 3 42 -2 -42
		mu 0 3 58 2 1
		f 3 -3 -43 43
		mu 0 3 3 2 58
		f 3 -4 -44 44
		mu 0 3 4 3 58
		f 3 -5 -45 45
		mu 0 3 5 4 58
		f 3 -46 46 -69
		mu 0 3 5 58 6
		f 3 -6 -47 47
		mu 0 3 7 6 58
		f 3 -7 -48 48
		mu 0 3 8 7 58
		f 3 -8 -49 49
		mu 0 3 9 8 58
		f 3 -9 -50 50
		mu 0 3 10 9 58
		f 3 73 -10 -51
		mu 0 3 58 63 10
		f 3 -11 -52 52
		mu 0 3 12 11 58
		f 3 -12 -53 53
		mu 0 3 13 12 58
		f 3 -13 -54 40
		mu 0 3 0 13 58
		f 3 13 55 -55
		mu 0 3 56 55 59
		f 3 -56 69 56
		mu 0 3 59 55 54
		f 3 -57 14 57
		mu 0 3 59 54 53
		f 3 15 58 -58
		mu 0 3 53 52 59
		f 3 -59 16 59
		mu 0 3 59 52 51
		f 3 60 -60 17
		mu 0 3 50 59 51
		f 3 18 61 -61
		mu 0 3 50 49 59
		f 3 19 62 -62
		mu 0 3 49 48 59
		f 3 -63 20 63
		mu 0 3 59 48 47
		f 3 21 64 -64
		mu 0 3 47 46 59
		f 3 22 71 -65
		mu 0 3 46 60 59
		f 3 -66 23 66
		mu 0 3 59 45 44
		f 3 24 67 -67
		mu 0 3 44 57 59
		f 3 25 54 -68
		mu 0 3 57 56 59
		f 3 -72 70 65
		mu 0 3 59 60 45
		f 3 -73 -74 51
		mu 0 3 11 63 58
		f 4 -75 72 37 -71
		mu 0 4 61 62 25 40
		f 4 75 102 -89 -102
		mu 0 4 66 67 68 69
		f 4 -103 76 103 -145
		mu 0 4 68 67 70 71
		f 4 -104 77 104 -90
		mu 0 4 71 70 72 73
		f 4 78 105 -91 -105
		mu 0 4 72 74 75 73
		f 4 -106 79 106 -92
		mu 0 4 75 74 76 77
		f 4 -93 -107 143 107
		mu 0 4 78 77 76 79
		f 4 80 108 -94 -108
		mu 0 4 79 80 81 78
		f 4 81 109 -95 -109
		mu 0 4 80 82 83 81
		f 4 -110 82 110 -96
		mu 0 4 84 85 86 87
		f 4 83 111 -97 -111
		mu 0 4 86 88 89 87
		f 4 84 149 -98 -112
		mu 0 4 88 90 91 89
		f 4 -113 85 113 -99
		mu 0 4 92 93 94 95
		f 4 86 114 -100 -114
		mu 0 4 94 96 97 95
		f 4 87 101 -101 -115
		mu 0 4 96 98 99 97
		f 3 -76 -116 116
		mu 0 3 100 101 102
		f 3 117 -77 -117
		mu 0 3 102 103 100
		f 3 -78 -118 118
		mu 0 3 104 103 102
		f 3 -79 -119 119
		mu 0 3 105 104 102
		f 3 -80 -120 120
		mu 0 3 106 105 102
		f 3 -121 121 -144
		mu 0 3 106 102 107
		f 3 -81 -122 122
		mu 0 3 108 107 102
		f 3 -82 -123 123
		mu 0 3 109 108 102
		f 3 -83 -124 124
		mu 0 3 110 109 102
		f 3 -84 -125 125
		mu 0 3 111 110 102
		f 3 148 -85 -126
		mu 0 3 102 112 111
		f 3 -86 -127 127
		mu 0 3 113 114 102
		f 3 -87 -128 128
		mu 0 3 115 113 102
		f 3 -88 -129 115
		mu 0 3 101 115 102
		f 3 88 130 -130
		mu 0 3 116 117 118
		f 3 -131 144 131
		mu 0 3 118 117 119
		f 3 -132 89 132
		mu 0 3 118 119 120
		f 3 90 133 -133
		mu 0 3 120 121 118
		f 3 -134 91 134
		mu 0 3 118 121 122
		f 3 135 -135 92
		mu 0 3 123 118 122
		f 3 93 136 -136
		mu 0 3 123 124 118
		f 3 94 137 -137
		mu 0 3 124 125 118
		f 3 -138 95 138
		mu 0 3 118 125 126
		f 3 96 139 -139
		mu 0 3 126 127 118
		f 3 97 146 -140
		mu 0 3 127 128 118
		f 3 -141 98 141
		mu 0 3 118 129 130
		f 3 99 142 -142
		mu 0 3 130 131 118
		f 3 100 129 -143
		mu 0 3 131 116 118
		f 3 -147 145 140
		mu 0 3 118 128 129
		f 3 -148 -149 126
		mu 0 3 114 112 102
		f 4 -150 147 112 -146
		mu 0 4 91 90 93 92
		f 4 150 177 -164 -177
		mu 0 4 132 133 134 135
		f 4 -178 151 178 -220
		mu 0 4 134 133 136 137
		f 4 -179 152 179 -165
		mu 0 4 137 136 138 139
		f 4 153 180 -166 -180
		mu 0 4 138 140 141 139
		f 4 -181 154 181 -167
		mu 0 4 141 140 142 143
		f 4 -168 -182 218 182
		mu 0 4 144 143 142 145
		f 4 155 183 -169 -183
		mu 0 4 145 146 147 144
		f 4 156 184 -170 -184
		mu 0 4 146 148 149 147
		f 4 -185 157 185 -171
		mu 0 4 150 151 152 153
		f 4 158 186 -172 -186
		mu 0 4 152 154 155 153
		f 4 159 224 -173 -187
		mu 0 4 154 156 157 155
		f 4 -188 160 188 -174
		mu 0 4 158 159 160 161
		f 4 161 189 -175 -189
		mu 0 4 160 162 163 161
		f 4 162 176 -176 -190
		mu 0 4 162 164 165 163
		f 3 -151 -191 191
		mu 0 3 166 167 168
		f 3 192 -152 -192
		mu 0 3 168 169 166
		f 3 -153 -193 193
		mu 0 3 170 169 168
		f 3 -154 -194 194
		mu 0 3 171 170 168
		f 3 -155 -195 195
		mu 0 3 172 171 168
		f 3 -196 196 -219
		mu 0 3 172 168 173
		f 3 -156 -197 197
		mu 0 3 174 173 168
		f 3 -157 -198 198
		mu 0 3 175 174 168
		f 3 -158 -199 199
		mu 0 3 176 175 168
		f 3 -159 -200 200
		mu 0 3 177 176 168
		f 3 223 -160 -201
		mu 0 3 168 178 177
		f 3 -161 -202 202
		mu 0 3 179 180 168
		f 3 -162 -203 203
		mu 0 3 181 179 168
		f 3 -163 -204 190
		mu 0 3 167 181 168
		f 3 163 205 -205
		mu 0 3 182 183 184
		f 3 -206 219 206
		mu 0 3 184 183 185
		f 3 -207 164 207
		mu 0 3 184 185 186
		f 3 165 208 -208
		mu 0 3 186 187 184
		f 3 -209 166 209
		mu 0 3 184 187 188
		f 3 210 -210 167
		mu 0 3 189 184 188
		f 3 168 211 -211
		mu 0 3 189 190 184
		f 3 169 212 -212
		mu 0 3 190 191 184
		f 3 -213 170 213
		mu 0 3 184 191 192
		f 3 171 214 -214
		mu 0 3 192 193 184
		f 3 172 221 -215
		mu 0 3 193 194 184
		f 3 -216 173 216
		mu 0 3 184 195 196
		f 3 174 217 -217
		mu 0 3 196 197 184
		f 3 175 204 -218
		mu 0 3 197 182 184
		f 3 -222 220 215
		mu 0 3 184 194 195
		f 3 -223 -224 201
		mu 0 3 180 178 168
		f 4 -225 222 187 -221
		mu 0 4 157 156 159 158;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
createNode lightLinker -s -n "lightLinker1";
	rename -uid "1EEF8BA4-4ADC-DD2F-0B7E-0885EDEF803D";
	setAttr -s 4 ".lnk";
	setAttr -s 4 ".slnk";
createNode shapeEditorManager -n "shapeEditorManager";
	rename -uid "5C711946-4616-D87C-0B0F-71A632430397";
createNode poseInterpolatorManager -n "poseInterpolatorManager";
	rename -uid "6446D43B-4B2F-FB64-D9D2-86B655B30687";
createNode displayLayerManager -n "layerManager";
	rename -uid "9F5615D8-45BE-2F17-097D-6198F5988FD6";
createNode displayLayer -n "defaultLayer";
	rename -uid "3BE835E4-46DE-052D-6947-058EC0E58C8F";
	setAttr ".ufem" -type "stringArray" 0  ;
createNode renderLayerManager -n "renderLayerManager";
	rename -uid "CD20602D-468A-6736-FDAA-89A32DAAB862";
createNode renderLayer -n "defaultRenderLayer";
	rename -uid "0381DAD2-451F-722C-7836-0792DB01A692";
	setAttr ".g" yes;
createNode aiOptions -s -n "defaultArnoldRenderOptions";
	rename -uid "FCF907FD-451B-7BEC-E166-C4B3BCF84348";
	setAttr ".version" -type "string" "5.2.0";
createNode aiAOVFilter -s -n "defaultArnoldFilter";
	rename -uid "70A68B0E-4F55-4F08-1DA9-FCB3D75E6F6A";
	setAttr ".ai_translator" -type "string" "gaussian";
createNode aiAOVDriver -s -n "defaultArnoldDriver";
	rename -uid "6544C537-4635-7B8C-57CE-9BAF87BD4E09";
	setAttr ".ai_translator" -type "string" "exr";
createNode aiAOVDriver -s -n "defaultArnoldDisplayDriver";
	rename -uid "3300FC1F-4DD8-BB2A-472A-DDB2E7A3BF7F";
	setAttr ".output_mode" 0;
	setAttr ".ai_translator" -type "string" "maya";
createNode blinn -n "blinn1";
	rename -uid "58E45C99-4BA5-5C05-B59D-60BCFFF6500C";
createNode shadingEngine -n "blinn1SG";
	rename -uid "0BF363E6-4310-43D9-C745-5FBEE1E144FB";
	setAttr ".ihi" 0;
	setAttr ".ro" yes;
createNode materialInfo -n "materialInfo1";
	rename -uid "A61413EB-4827-D3D9-BB6E-2F9EA17B4CDA";
createNode lambert -n "lambert2";
	rename -uid "76F3A3B3-43CE-1584-E5F9-799F0B5D873B";
createNode shadingEngine -n "lambert2SG";
	rename -uid "73E57FAF-4AF6-86EE-803F-43A1B5A3F483";
	setAttr ".ihi" 0;
	setAttr ".ro" yes;
createNode materialInfo -n "materialInfo2";
	rename -uid "0010ECD6-4512-DA2C-1E91-99A083BA0829";
createNode script -n "uiConfigurationScriptNode";
	rename -uid "E1AD2B02-42F3-1807-7A7E-58B947DAF316";
	setAttr ".b" -type "string" (
		"// Maya Mel UI Configuration File.\n//\n//  This script is machine generated.  Edit at your own risk.\n//\n//\n\nglobal string $gMainPane;\nif (`paneLayout -exists $gMainPane`) {\n\n\tglobal int $gUseScenePanelConfig;\n\tint    $useSceneConfig = $gUseScenePanelConfig;\n\tint    $nodeEditorPanelVisible = stringArrayContains(\"nodeEditorPanel1\", `getPanel -vis`);\n\tint    $nodeEditorWorkspaceControlOpen = (`workspaceControl -exists nodeEditorPanel1Window` && `workspaceControl -q -visible nodeEditorPanel1Window`);\n\tint    $menusOkayInPanels = `optionVar -q allowMenusInPanels`;\n\tint    $nVisPanes = `paneLayout -q -nvp $gMainPane`;\n\tint    $nPanes = 0;\n\tstring $editorName;\n\tstring $panelName;\n\tstring $itemFilterName;\n\tstring $panelConfig;\n\n\t//\n\t//  get current state of the UI\n\t//\n\tsceneUIReplacement -update $gMainPane;\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"modelPanel\" (localizedPanelLabel(\"Top View\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tmodelPanel -edit -l (localizedPanelLabel(\"Top View\")) -mbv $menusOkayInPanels  $panelName;\n"
		+ "\t\t$editorName = $panelName;\n        modelEditor -e \n            -camera \"|top\" \n            -useInteractiveMode 0\n            -displayLights \"default\" \n            -displayAppearance \"wireframe\" \n            -activeOnly 0\n            -ignorePanZoom 0\n            -wireframeOnShaded 0\n            -headsUpDisplay 1\n            -holdOuts 1\n            -selectionHiliteDisplay 1\n            -useDefaultMaterial 0\n            -bufferMode \"double\" \n            -twoSidedLighting 0\n            -backfaceCulling 0\n            -xray 0\n            -jointXray 0\n            -activeComponentsXray 0\n            -displayTextures 0\n            -smoothWireframe 0\n            -lineWidth 1\n            -textureAnisotropic 0\n            -textureHilight 1\n            -textureSampling 2\n            -textureDisplay \"modulate\" \n            -textureMaxSize 32768\n            -fogging 0\n            -fogSource \"fragment\" \n            -fogMode \"linear\" \n            -fogStart 0\n            -fogEnd 100\n            -fogDensity 0.1\n            -fogColor 0.5 0.5 0.5 1 \n"
		+ "            -depthOfFieldPreview 1\n            -maxConstantTransparency 1\n            -rendererName \"vp2Renderer\" \n            -objectFilterShowInHUD 1\n            -isFiltered 0\n            -colorResolution 256 256 \n            -bumpResolution 512 512 \n            -textureCompression 0\n            -transparencyAlgorithm \"frontAndBackCull\" \n            -transpInShadows 0\n            -cullingOverride \"none\" \n            -lowQualityLighting 0\n            -maximumNumHardwareLights 1\n            -occlusionCulling 0\n            -shadingModel 0\n            -useBaseRenderer 0\n            -useReducedRenderer 0\n            -smallObjectCulling 0\n            -smallObjectThreshold -1 \n            -interactiveDisableShadows 0\n            -interactiveBackFaceCull 0\n            -sortTransparent 1\n            -controllers 1\n            -nurbsCurves 1\n            -nurbsSurfaces 1\n            -polymeshes 1\n            -subdivSurfaces 1\n            -planes 1\n            -lights 1\n            -cameras 1\n            -controlVertices 1\n"
		+ "            -hulls 1\n            -grid 1\n            -imagePlane 1\n            -joints 1\n            -ikHandles 1\n            -deformers 1\n            -dynamics 1\n            -particleInstancers 1\n            -fluids 1\n            -hairSystems 1\n            -follicles 1\n            -nCloths 1\n            -nParticles 1\n            -nRigids 1\n            -dynamicConstraints 1\n            -locators 1\n            -manipulators 1\n            -pluginShapes 1\n            -dimensions 1\n            -handles 1\n            -pivots 1\n            -textures 1\n            -strokes 1\n            -motionTrails 1\n            -clipGhosts 1\n            -bluePencil 1\n            -greasePencils 0\n            -shadows 0\n            -captureSequenceNumber -1\n            -width 616\n            -height 342\n            -sceneRenderFilter 0\n            $editorName;\n        modelEditor -e -viewSelected 0 $editorName;\n        modelEditor -e \n            -pluginObjects \"gpuCacheDisplayFilter\" 1 \n            $editorName;\n\t\tif (!$useSceneConfig) {\n"
		+ "\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"modelPanel\" (localizedPanelLabel(\"Side View\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tmodelPanel -edit -l (localizedPanelLabel(\"Side View\")) -mbv $menusOkayInPanels  $panelName;\n\t\t$editorName = $panelName;\n        modelEditor -e \n            -camera \"|side\" \n            -useInteractiveMode 0\n            -displayLights \"default\" \n            -displayAppearance \"smoothShaded\" \n            -activeOnly 0\n            -ignorePanZoom 0\n            -wireframeOnShaded 0\n            -headsUpDisplay 1\n            -holdOuts 1\n            -selectionHiliteDisplay 1\n            -useDefaultMaterial 0\n            -bufferMode \"double\" \n            -twoSidedLighting 0\n            -backfaceCulling 0\n            -xray 0\n            -jointXray 0\n            -activeComponentsXray 0\n            -displayTextures 0\n            -smoothWireframe 0\n            -lineWidth 1\n            -textureAnisotropic 0\n            -textureHilight 1\n"
		+ "            -textureSampling 2\n            -textureDisplay \"modulate\" \n            -textureMaxSize 32768\n            -fogging 0\n            -fogSource \"fragment\" \n            -fogMode \"linear\" \n            -fogStart 0\n            -fogEnd 100\n            -fogDensity 0.1\n            -fogColor 0.5 0.5 0.5 1 \n            -depthOfFieldPreview 1\n            -maxConstantTransparency 1\n            -rendererName \"vp2Renderer\" \n            -objectFilterShowInHUD 1\n            -isFiltered 0\n            -colorResolution 256 256 \n            -bumpResolution 512 512 \n            -textureCompression 0\n            -transparencyAlgorithm \"frontAndBackCull\" \n            -transpInShadows 0\n            -cullingOverride \"none\" \n            -lowQualityLighting 0\n            -maximumNumHardwareLights 1\n            -occlusionCulling 0\n            -shadingModel 0\n            -useBaseRenderer 0\n            -useReducedRenderer 0\n            -smallObjectCulling 0\n            -smallObjectThreshold -1 \n            -interactiveDisableShadows 0\n"
		+ "            -interactiveBackFaceCull 0\n            -sortTransparent 1\n            -controllers 1\n            -nurbsCurves 1\n            -nurbsSurfaces 1\n            -polymeshes 1\n            -subdivSurfaces 1\n            -planes 1\n            -lights 1\n            -cameras 1\n            -controlVertices 1\n            -hulls 1\n            -grid 1\n            -imagePlane 1\n            -joints 1\n            -ikHandles 1\n            -deformers 1\n            -dynamics 1\n            -particleInstancers 1\n            -fluids 1\n            -hairSystems 1\n            -follicles 1\n            -nCloths 1\n            -nParticles 1\n            -nRigids 1\n            -dynamicConstraints 1\n            -locators 1\n            -manipulators 1\n            -pluginShapes 1\n            -dimensions 1\n            -handles 1\n            -pivots 1\n            -textures 1\n            -strokes 1\n            -motionTrails 1\n            -clipGhosts 1\n            -bluePencil 1\n            -greasePencils 0\n            -shadows 0\n            -captureSequenceNumber -1\n"
		+ "            -width 616\n            -height 342\n            -sceneRenderFilter 0\n            $editorName;\n        modelEditor -e -viewSelected 0 $editorName;\n        modelEditor -e \n            -pluginObjects \"gpuCacheDisplayFilter\" 1 \n            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"modelPanel\" (localizedPanelLabel(\"Front View\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tmodelPanel -edit -l (localizedPanelLabel(\"Front View\")) -mbv $menusOkayInPanels  $panelName;\n\t\t$editorName = $panelName;\n        modelEditor -e \n            -camera \"|front\" \n            -useInteractiveMode 0\n            -displayLights \"default\" \n            -displayAppearance \"wireframe\" \n            -activeOnly 0\n            -ignorePanZoom 0\n            -wireframeOnShaded 0\n            -headsUpDisplay 1\n            -holdOuts 1\n            -selectionHiliteDisplay 1\n            -useDefaultMaterial 0\n            -bufferMode \"double\" \n"
		+ "            -twoSidedLighting 0\n            -backfaceCulling 0\n            -xray 0\n            -jointXray 0\n            -activeComponentsXray 0\n            -displayTextures 0\n            -smoothWireframe 0\n            -lineWidth 1\n            -textureAnisotropic 0\n            -textureHilight 1\n            -textureSampling 2\n            -textureDisplay \"modulate\" \n            -textureMaxSize 32768\n            -fogging 0\n            -fogSource \"fragment\" \n            -fogMode \"linear\" \n            -fogStart 0\n            -fogEnd 100\n            -fogDensity 0.1\n            -fogColor 0.5 0.5 0.5 1 \n            -depthOfFieldPreview 1\n            -maxConstantTransparency 1\n            -rendererName \"vp2Renderer\" \n            -objectFilterShowInHUD 1\n            -isFiltered 0\n            -colorResolution 256 256 \n            -bumpResolution 512 512 \n            -textureCompression 0\n            -transparencyAlgorithm \"frontAndBackCull\" \n            -transpInShadows 0\n            -cullingOverride \"none\" \n            -lowQualityLighting 0\n"
		+ "            -maximumNumHardwareLights 1\n            -occlusionCulling 0\n            -shadingModel 0\n            -useBaseRenderer 0\n            -useReducedRenderer 0\n            -smallObjectCulling 0\n            -smallObjectThreshold -1 \n            -interactiveDisableShadows 0\n            -interactiveBackFaceCull 0\n            -sortTransparent 1\n            -controllers 1\n            -nurbsCurves 1\n            -nurbsSurfaces 1\n            -polymeshes 1\n            -subdivSurfaces 1\n            -planes 1\n            -lights 1\n            -cameras 1\n            -controlVertices 1\n            -hulls 1\n            -grid 1\n            -imagePlane 1\n            -joints 1\n            -ikHandles 1\n            -deformers 1\n            -dynamics 1\n            -particleInstancers 1\n            -fluids 1\n            -hairSystems 1\n            -follicles 1\n            -nCloths 1\n            -nParticles 1\n            -nRigids 1\n            -dynamicConstraints 1\n            -locators 1\n            -manipulators 1\n            -pluginShapes 1\n"
		+ "            -dimensions 1\n            -handles 1\n            -pivots 1\n            -textures 1\n            -strokes 1\n            -motionTrails 1\n            -clipGhosts 1\n            -bluePencil 1\n            -greasePencils 0\n            -shadows 0\n            -captureSequenceNumber -1\n            -width 616\n            -height 342\n            -sceneRenderFilter 0\n            $editorName;\n        modelEditor -e -viewSelected 0 $editorName;\n        modelEditor -e \n            -pluginObjects \"gpuCacheDisplayFilter\" 1 \n            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"modelPanel\" (localizedPanelLabel(\"Persp View\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tmodelPanel -edit -l (localizedPanelLabel(\"Persp View\")) -mbv $menusOkayInPanels  $panelName;\n\t\t$editorName = $panelName;\n        modelEditor -e \n            -camera \"|persp\" \n            -useInteractiveMode 0\n            -displayLights \"default\" \n"
		+ "            -displayAppearance \"smoothShaded\" \n            -activeOnly 0\n            -ignorePanZoom 0\n            -wireframeOnShaded 0\n            -headsUpDisplay 1\n            -holdOuts 1\n            -selectionHiliteDisplay 1\n            -useDefaultMaterial 0\n            -bufferMode \"double\" \n            -twoSidedLighting 0\n            -backfaceCulling 0\n            -xray 0\n            -jointXray 0\n            -activeComponentsXray 0\n            -displayTextures 0\n            -smoothWireframe 0\n            -lineWidth 1\n            -textureAnisotropic 0\n            -textureHilight 1\n            -textureSampling 2\n            -textureDisplay \"modulate\" \n            -textureMaxSize 32768\n            -fogging 0\n            -fogSource \"fragment\" \n            -fogMode \"linear\" \n            -fogStart 0\n            -fogEnd 100\n            -fogDensity 0.1\n            -fogColor 0.5 0.5 0.5 1 \n            -depthOfFieldPreview 1\n            -maxConstantTransparency 1\n            -rendererName \"vp2Renderer\" \n            -objectFilterShowInHUD 1\n"
		+ "            -isFiltered 0\n            -colorResolution 256 256 \n            -bumpResolution 512 512 \n            -textureCompression 0\n            -transparencyAlgorithm \"frontAndBackCull\" \n            -transpInShadows 0\n            -cullingOverride \"none\" \n            -lowQualityLighting 0\n            -maximumNumHardwareLights 1\n            -occlusionCulling 0\n            -shadingModel 0\n            -useBaseRenderer 0\n            -useReducedRenderer 0\n            -smallObjectCulling 0\n            -smallObjectThreshold -1 \n            -interactiveDisableShadows 0\n            -interactiveBackFaceCull 0\n            -sortTransparent 1\n            -controllers 1\n            -nurbsCurves 1\n            -nurbsSurfaces 1\n            -polymeshes 1\n            -subdivSurfaces 1\n            -planes 1\n            -lights 1\n            -cameras 1\n            -controlVertices 1\n            -hulls 1\n            -grid 1\n            -imagePlane 1\n            -joints 1\n            -ikHandles 1\n            -deformers 1\n            -dynamics 1\n"
		+ "            -particleInstancers 1\n            -fluids 1\n            -hairSystems 1\n            -follicles 1\n            -nCloths 1\n            -nParticles 1\n            -nRigids 1\n            -dynamicConstraints 1\n            -locators 1\n            -manipulators 1\n            -pluginShapes 1\n            -dimensions 1\n            -handles 1\n            -pivots 1\n            -textures 1\n            -strokes 1\n            -motionTrails 1\n            -clipGhosts 1\n            -bluePencil 1\n            -greasePencils 0\n            -shadows 0\n            -captureSequenceNumber -1\n            -width 1002\n            -height 729\n            -sceneRenderFilter 0\n            $editorName;\n        modelEditor -e -viewSelected 0 $editorName;\n        modelEditor -e \n            -pluginObjects \"gpuCacheDisplayFilter\" 1 \n            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"outlinerPanel\" (localizedPanelLabel(\"ToggledOutliner\")) `;\n\tif (\"\" != $panelName) {\n"
		+ "\t\t$label = `panel -q -label $panelName`;\n\t\toutlinerPanel -edit -l (localizedPanelLabel(\"ToggledOutliner\")) -mbv $menusOkayInPanels  $panelName;\n\t\t$editorName = $panelName;\n        outlinerEditor -e \n            -docTag \"isolOutln_fromSeln\" \n            -showShapes 0\n            -showAssignedMaterials 0\n            -showTimeEditor 1\n            -showReferenceNodes 1\n            -showReferenceMembers 1\n            -showAttributes 0\n            -showConnected 0\n            -showAnimCurvesOnly 0\n            -showMuteInfo 0\n            -organizeByLayer 1\n            -organizeByClip 1\n            -showAnimLayerWeight 1\n            -autoExpandLayers 1\n            -autoExpand 0\n            -showDagOnly 1\n            -showAssets 1\n            -showContainedOnly 1\n            -showPublishedAsConnected 0\n            -showParentContainers 0\n            -showContainerContents 1\n            -ignoreDagHierarchy 0\n            -expandConnections 0\n            -showUpstreamCurves 1\n            -showUnitlessCurves 1\n            -showCompounds 1\n"
		+ "            -showLeafs 1\n            -showNumericAttrsOnly 0\n            -highlightActive 1\n            -autoSelectNewObjects 0\n            -doNotSelectNewObjects 0\n            -dropIsParent 1\n            -transmitFilters 0\n            -setFilter \"defaultSetFilter\" \n            -showSetMembers 1\n            -allowMultiSelection 1\n            -alwaysToggleSelect 0\n            -directSelect 0\n            -isSet 0\n            -isSetMember 0\n            -displayMode \"DAG\" \n            -expandObjects 0\n            -setsIgnoreFilters 1\n            -containersIgnoreFilters 0\n            -editAttrName 0\n            -showAttrValues 0\n            -highlightSecondary 0\n            -showUVAttrsOnly 0\n            -showTextureNodesOnly 0\n            -attrAlphaOrder \"default\" \n            -animLayerFilterOptions \"allAffecting\" \n            -sortOrder \"none\" \n            -longNames 0\n            -niceNames 1\n            -selectCommand \"print(\\\"\\\")\" \n            -showNamespace 1\n            -showPinIcons 0\n            -mapMotionTrails 0\n"
		+ "            -ignoreHiddenAttribute 0\n            -ignoreOutlinerColor 0\n            -renderFilterVisible 0\n            -renderFilterIndex 0\n            -selectionOrder \"chronological\" \n            -expandAttribute 0\n            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"outlinerPanel\" (localizedPanelLabel(\"Outliner\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\toutlinerPanel -edit -l (localizedPanelLabel(\"Outliner\")) -mbv $menusOkayInPanels  $panelName;\n\t\t$editorName = $panelName;\n        outlinerEditor -e \n            -showShapes 0\n            -showAssignedMaterials 0\n            -showTimeEditor 1\n            -showReferenceNodes 0\n            -showReferenceMembers 0\n            -showAttributes 0\n            -showConnected 0\n            -showAnimCurvesOnly 0\n            -showMuteInfo 0\n            -organizeByLayer 1\n            -organizeByClip 1\n            -showAnimLayerWeight 1\n            -autoExpandLayers 1\n"
		+ "            -autoExpand 0\n            -showDagOnly 1\n            -showAssets 1\n            -showContainedOnly 1\n            -showPublishedAsConnected 0\n            -showParentContainers 0\n            -showContainerContents 1\n            -ignoreDagHierarchy 0\n            -expandConnections 0\n            -showUpstreamCurves 1\n            -showUnitlessCurves 1\n            -showCompounds 1\n            -showLeafs 1\n            -showNumericAttrsOnly 0\n            -highlightActive 1\n            -autoSelectNewObjects 0\n            -doNotSelectNewObjects 0\n            -dropIsParent 1\n            -transmitFilters 0\n            -setFilter \"defaultSetFilter\" \n            -showSetMembers 1\n            -allowMultiSelection 1\n            -alwaysToggleSelect 0\n            -directSelect 0\n            -displayMode \"DAG\" \n            -expandObjects 0\n            -setsIgnoreFilters 1\n            -containersIgnoreFilters 0\n            -editAttrName 0\n            -showAttrValues 0\n            -highlightSecondary 0\n            -showUVAttrsOnly 0\n"
		+ "            -showTextureNodesOnly 0\n            -attrAlphaOrder \"default\" \n            -animLayerFilterOptions \"allAffecting\" \n            -sortOrder \"none\" \n            -longNames 0\n            -niceNames 1\n            -showNamespace 1\n            -showPinIcons 0\n            -mapMotionTrails 0\n            -ignoreHiddenAttribute 0\n            -ignoreOutlinerColor 0\n            -renderFilterVisible 0\n            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"graphEditor\" (localizedPanelLabel(\"Graph Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Graph Editor\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = ($panelName+\"OutlineEd\");\n            outlinerEditor -e \n                -showShapes 1\n                -showAssignedMaterials 0\n                -showTimeEditor 1\n                -showReferenceNodes 0\n                -showReferenceMembers 0\n"
		+ "                -showAttributes 1\n                -showConnected 1\n                -showAnimCurvesOnly 1\n                -showMuteInfo 0\n                -organizeByLayer 1\n                -organizeByClip 1\n                -showAnimLayerWeight 1\n                -autoExpandLayers 1\n                -autoExpand 1\n                -showDagOnly 0\n                -showAssets 1\n                -showContainedOnly 0\n                -showPublishedAsConnected 0\n                -showParentContainers 0\n                -showContainerContents 0\n                -ignoreDagHierarchy 0\n                -expandConnections 1\n                -showUpstreamCurves 1\n                -showUnitlessCurves 1\n                -showCompounds 0\n                -showLeafs 1\n                -showNumericAttrsOnly 1\n                -highlightActive 0\n                -autoSelectNewObjects 1\n                -doNotSelectNewObjects 0\n                -dropIsParent 1\n                -transmitFilters 1\n                -setFilter \"0\" \n                -showSetMembers 0\n"
		+ "                -allowMultiSelection 1\n                -alwaysToggleSelect 0\n                -directSelect 0\n                -displayMode \"DAG\" \n                -expandObjects 0\n                -setsIgnoreFilters 1\n                -containersIgnoreFilters 0\n                -editAttrName 0\n                -showAttrValues 0\n                -highlightSecondary 0\n                -showUVAttrsOnly 0\n                -showTextureNodesOnly 0\n                -attrAlphaOrder \"default\" \n                -animLayerFilterOptions \"allAffecting\" \n                -sortOrder \"none\" \n                -longNames 0\n                -niceNames 1\n                -showNamespace 1\n                -showPinIcons 1\n                -mapMotionTrails 1\n                -ignoreHiddenAttribute 0\n                -ignoreOutlinerColor 0\n                -renderFilterVisible 0\n                $editorName;\n\n\t\t\t$editorName = ($panelName+\"GraphEd\");\n            animCurveEditor -e \n                -displayValues 0\n                -snapTime \"integer\" \n                -snapValue \"none\" \n"
		+ "                -showPlayRangeShades \"on\" \n                -lockPlayRangeShades \"off\" \n                -smoothness \"fine\" \n                -resultSamples 1\n                -resultScreenSamples 0\n                -resultUpdate \"delayed\" \n                -showUpstreamCurves 1\n                -keyMinScale 1\n                -stackedCurvesMin -1\n                -stackedCurvesMax 1\n                -stackedCurvesSpace 0.2\n                -preSelectionHighlight 0\n                -constrainDrag 0\n                -valueLinesToggle 1\n                -highlightAffectedCurves 0\n                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"dopeSheetPanel\" (localizedPanelLabel(\"Dope Sheet\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Dope Sheet\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = ($panelName+\"OutlineEd\");\n            outlinerEditor -e \n                -showShapes 1\n"
		+ "                -showAssignedMaterials 0\n                -showTimeEditor 1\n                -showReferenceNodes 0\n                -showReferenceMembers 0\n                -showAttributes 1\n                -showConnected 1\n                -showAnimCurvesOnly 1\n                -showMuteInfo 0\n                -organizeByLayer 1\n                -organizeByClip 1\n                -showAnimLayerWeight 1\n                -autoExpandLayers 1\n                -autoExpand 0\n                -showDagOnly 0\n                -showAssets 1\n                -showContainedOnly 0\n                -showPublishedAsConnected 0\n                -showParentContainers 0\n                -showContainerContents 0\n                -ignoreDagHierarchy 0\n                -expandConnections 1\n                -showUpstreamCurves 1\n                -showUnitlessCurves 0\n                -showCompounds 1\n                -showLeafs 1\n                -showNumericAttrsOnly 1\n                -highlightActive 0\n                -autoSelectNewObjects 0\n                -doNotSelectNewObjects 1\n"
		+ "                -dropIsParent 1\n                -transmitFilters 0\n                -setFilter \"0\" \n                -showSetMembers 0\n                -allowMultiSelection 1\n                -alwaysToggleSelect 0\n                -directSelect 0\n                -displayMode \"DAG\" \n                -expandObjects 0\n                -setsIgnoreFilters 1\n                -containersIgnoreFilters 0\n                -editAttrName 0\n                -showAttrValues 0\n                -highlightSecondary 0\n                -showUVAttrsOnly 0\n                -showTextureNodesOnly 0\n                -attrAlphaOrder \"default\" \n                -animLayerFilterOptions \"allAffecting\" \n                -sortOrder \"none\" \n                -longNames 0\n                -niceNames 1\n                -showNamespace 1\n                -showPinIcons 0\n                -mapMotionTrails 1\n                -ignoreHiddenAttribute 0\n                -ignoreOutlinerColor 0\n                -renderFilterVisible 0\n                $editorName;\n\n\t\t\t$editorName = ($panelName+\"DopeSheetEd\");\n"
		+ "            dopeSheetEditor -e \n                -displayValues 0\n                -snapTime \"integer\" \n                -snapValue \"none\" \n                -outliner \"dopeSheetPanel1OutlineEd\" \n                -showSummary 1\n                -showScene 0\n                -hierarchyBelow 0\n                -showTicks 1\n                -selectionWindow 0 0 0 0 \n                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"timeEditorPanel\" (localizedPanelLabel(\"Time Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Time Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"clipEditorPanel\" (localizedPanelLabel(\"Trax Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Trax Editor\")) -mbv $menusOkayInPanels  $panelName;\n"
		+ "\n\t\t\t$editorName = clipEditorNameFromPanel($panelName);\n            clipEditor -e \n                -displayValues 0\n                -snapTime \"none\" \n                -snapValue \"none\" \n                -initialized 0\n                -manageSequencer 0 \n                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"sequenceEditorPanel\" (localizedPanelLabel(\"Camera Sequencer\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Camera Sequencer\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = sequenceEditorNameFromPanel($panelName);\n            clipEditor -e \n                -displayValues 0\n                -snapTime \"none\" \n                -snapValue \"none\" \n                -initialized 0\n                -manageSequencer 1 \n                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"hyperGraphPanel\" (localizedPanelLabel(\"Hypergraph Hierarchy\")) `;\n"
		+ "\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Hypergraph Hierarchy\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = ($panelName+\"HyperGraphEd\");\n            hyperGraph -e \n                -graphLayoutStyle \"hierarchicalLayout\" \n                -orientation \"horiz\" \n                -mergeConnections 0\n                -zoom 1\n                -animateTransition 0\n                -showRelationships 1\n                -showShapes 0\n                -showDeformers 0\n                -showExpressions 0\n                -showConstraints 0\n                -showConnectionFromSelected 0\n                -showConnectionToSelected 0\n                -showConstraintLabels 0\n                -showUnderworld 0\n                -showInvisible 0\n                -transitionFrames 1\n                -opaqueContainers 0\n                -freeform 0\n                -imagePosition 0 0 \n                -imageScale 1\n                -imageEnabled 0\n                -graphType \"DAG\" \n"
		+ "                -heatMapDisplay 0\n                -updateSelection 1\n                -updateNodeAdded 1\n                -useDrawOverrideColor 0\n                -limitGraphTraversal -1\n                -range 0 0 \n                -iconSize \"smallIcons\" \n                -showCachedConnections 0\n                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"hyperShadePanel\" (localizedPanelLabel(\"Hypershade\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Hypershade\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"visorPanel\" (localizedPanelLabel(\"Visor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Visor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n"
		+ "\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"nodeEditorPanel\" (localizedPanelLabel(\"Node Editor\")) `;\n\tif ($nodeEditorPanelVisible || $nodeEditorWorkspaceControlOpen) {\n\t\tif (\"\" == $panelName) {\n\t\t\tif ($useSceneConfig) {\n\t\t\t\t$panelName = `scriptedPanel -unParent  -type \"nodeEditorPanel\" -l (localizedPanelLabel(\"Node Editor\")) -mbv $menusOkayInPanels `;\n\n\t\t\t$editorName = ($panelName+\"NodeEditorEd\");\n            nodeEditor -e \n                -allAttributes 0\n                -allNodes 0\n                -autoSizeNodes 1\n                -consistentNameSize 1\n                -createNodeCommand \"nodeEdCreateNodeCommand\" \n                -connectNodeOnCreation 0\n                -connectOnDrop 0\n                -copyConnectionsOnPaste 0\n                -connectionStyle \"bezier\" \n                -defaultPinnedState 0\n                -additiveGraphingMode 0\n                -connectedGraphingMode 1\n                -settingsChangedCallback \"nodeEdSyncControls\" \n                -traversalDepthLimit -1\n"
		+ "                -keyPressCommand \"nodeEdKeyPressCommand\" \n                -nodeTitleMode \"name\" \n                -gridSnap 0\n                -gridVisibility 1\n                -crosshairOnEdgeDragging 0\n                -popupMenuScript \"nodeEdBuildPanelMenus\" \n                -showNamespace 1\n                -showShapes 1\n                -showSGShapes 0\n                -showTransforms 1\n                -useAssets 1\n                -syncedSelection 1\n                -extendToShapes 1\n                -showUnitConversions 0\n                -editorMode \"default\" \n                -hasWatchpoint 0\n                $editorName;\n\t\t\t}\n\t\t} else {\n\t\t\t$label = `panel -q -label $panelName`;\n\t\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Node Editor\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = ($panelName+\"NodeEditorEd\");\n            nodeEditor -e \n                -allAttributes 0\n                -allNodes 0\n                -autoSizeNodes 1\n                -consistentNameSize 1\n                -createNodeCommand \"nodeEdCreateNodeCommand\" \n"
		+ "                -connectNodeOnCreation 0\n                -connectOnDrop 0\n                -copyConnectionsOnPaste 0\n                -connectionStyle \"bezier\" \n                -defaultPinnedState 0\n                -additiveGraphingMode 0\n                -connectedGraphingMode 1\n                -settingsChangedCallback \"nodeEdSyncControls\" \n                -traversalDepthLimit -1\n                -keyPressCommand \"nodeEdKeyPressCommand\" \n                -nodeTitleMode \"name\" \n                -gridSnap 0\n                -gridVisibility 1\n                -crosshairOnEdgeDragging 0\n                -popupMenuScript \"nodeEdBuildPanelMenus\" \n                -showNamespace 1\n                -showShapes 1\n                -showSGShapes 0\n                -showTransforms 1\n                -useAssets 1\n                -syncedSelection 1\n                -extendToShapes 1\n                -showUnitConversions 0\n                -editorMode \"default\" \n                -hasWatchpoint 0\n                $editorName;\n\t\t\tif (!$useSceneConfig) {\n"
		+ "\t\t\t\tpanel -e -l $label $panelName;\n\t\t\t}\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"createNodePanel\" (localizedPanelLabel(\"Create Node\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Create Node\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"polyTexturePlacementPanel\" (localizedPanelLabel(\"UV Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"UV Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"renderWindowPanel\" (localizedPanelLabel(\"Render View\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Render View\")) -mbv $menusOkayInPanels  $panelName;\n"
		+ "\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"shapePanel\" (localizedPanelLabel(\"Shape Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tshapePanel -edit -l (localizedPanelLabel(\"Shape Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"posePanel\" (localizedPanelLabel(\"Pose Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tposePanel -edit -l (localizedPanelLabel(\"Pose Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"dynRelEdPanel\" (localizedPanelLabel(\"Dynamic Relationships\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Dynamic Relationships\")) -mbv $menusOkayInPanels  $panelName;\n"
		+ "\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"relationshipPanel\" (localizedPanelLabel(\"Relationship Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Relationship Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"referenceEditorPanel\" (localizedPanelLabel(\"Reference Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Reference Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"dynPaintScriptedPanelType\" (localizedPanelLabel(\"Paint Effects\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Paint Effects\")) -mbv $menusOkayInPanels  $panelName;\n"
		+ "\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"scriptEditorPanel\" (localizedPanelLabel(\"Script Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Script Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"profilerPanel\" (localizedPanelLabel(\"Profiler Tool\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Profiler Tool\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"contentBrowserPanel\" (localizedPanelLabel(\"Content Browser\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Content Browser\")) -mbv $menusOkayInPanels  $panelName;\n"
		+ "\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\tif ($useSceneConfig) {\n        string $configName = `getPanel -cwl (localizedPanelLabel(\"Current Layout\"))`;\n        if (\"\" != $configName) {\n\t\t\tpanelConfiguration -edit -label (localizedPanelLabel(\"Current Layout\")) \n\t\t\t\t-userCreated false\n\t\t\t\t-defaultImage \"vacantCell.xP:/\"\n\t\t\t\t-image \"\"\n\t\t\t\t-sc false\n\t\t\t\t-configString \"global string $gMainPane; paneLayout -e -cn \\\"single\\\" -ps 1 100 100 $gMainPane;\"\n\t\t\t\t-removeAllPanels\n\t\t\t\t-ap false\n\t\t\t\t\t(localizedPanelLabel(\"Persp View\")) \n\t\t\t\t\t\"modelPanel\"\n"
		+ "\t\t\t\t\t\"$panelName = `modelPanel -unParent -l (localizedPanelLabel(\\\"Persp View\\\")) -mbv $menusOkayInPanels `;\\n$editorName = $panelName;\\nmodelEditor -e \\n    -cam `findStartUpCamera persp` \\n    -useInteractiveMode 0\\n    -displayLights \\\"default\\\" \\n    -displayAppearance \\\"smoothShaded\\\" \\n    -activeOnly 0\\n    -ignorePanZoom 0\\n    -wireframeOnShaded 0\\n    -headsUpDisplay 1\\n    -holdOuts 1\\n    -selectionHiliteDisplay 1\\n    -useDefaultMaterial 0\\n    -bufferMode \\\"double\\\" \\n    -twoSidedLighting 0\\n    -backfaceCulling 0\\n    -xray 0\\n    -jointXray 0\\n    -activeComponentsXray 0\\n    -displayTextures 0\\n    -smoothWireframe 0\\n    -lineWidth 1\\n    -textureAnisotropic 0\\n    -textureHilight 1\\n    -textureSampling 2\\n    -textureDisplay \\\"modulate\\\" \\n    -textureMaxSize 32768\\n    -fogging 0\\n    -fogSource \\\"fragment\\\" \\n    -fogMode \\\"linear\\\" \\n    -fogStart 0\\n    -fogEnd 100\\n    -fogDensity 0.1\\n    -fogColor 0.5 0.5 0.5 1 \\n    -depthOfFieldPreview 1\\n    -maxConstantTransparency 1\\n    -rendererName \\\"vp2Renderer\\\" \\n    -objectFilterShowInHUD 1\\n    -isFiltered 0\\n    -colorResolution 256 256 \\n    -bumpResolution 512 512 \\n    -textureCompression 0\\n    -transparencyAlgorithm \\\"frontAndBackCull\\\" \\n    -transpInShadows 0\\n    -cullingOverride \\\"none\\\" \\n    -lowQualityLighting 0\\n    -maximumNumHardwareLights 1\\n    -occlusionCulling 0\\n    -shadingModel 0\\n    -useBaseRenderer 0\\n    -useReducedRenderer 0\\n    -smallObjectCulling 0\\n    -smallObjectThreshold -1 \\n    -interactiveDisableShadows 0\\n    -interactiveBackFaceCull 0\\n    -sortTransparent 1\\n    -controllers 1\\n    -nurbsCurves 1\\n    -nurbsSurfaces 1\\n    -polymeshes 1\\n    -subdivSurfaces 1\\n    -planes 1\\n    -lights 1\\n    -cameras 1\\n    -controlVertices 1\\n    -hulls 1\\n    -grid 1\\n    -imagePlane 1\\n    -joints 1\\n    -ikHandles 1\\n    -deformers 1\\n    -dynamics 1\\n    -particleInstancers 1\\n    -fluids 1\\n    -hairSystems 1\\n    -follicles 1\\n    -nCloths 1\\n    -nParticles 1\\n    -nRigids 1\\n    -dynamicConstraints 1\\n    -locators 1\\n    -manipulators 1\\n    -pluginShapes 1\\n    -dimensions 1\\n    -handles 1\\n    -pivots 1\\n    -textures 1\\n    -strokes 1\\n    -motionTrails 1\\n    -clipGhosts 1\\n    -bluePencil 1\\n    -greasePencils 0\\n    -shadows 0\\n    -captureSequenceNumber -1\\n    -width 1002\\n    -height 729\\n    -sceneRenderFilter 0\\n    $editorName;\\nmodelEditor -e -viewSelected 0 $editorName;\\nmodelEditor -e \\n    -pluginObjects \\\"gpuCacheDisplayFilter\\\" 1 \\n    $editorName\"\n"
		+ "\t\t\t\t\t\"modelPanel -edit -l (localizedPanelLabel(\\\"Persp View\\\")) -mbv $menusOkayInPanels  $panelName;\\n$editorName = $panelName;\\nmodelEditor -e \\n    -cam `findStartUpCamera persp` \\n    -useInteractiveMode 0\\n    -displayLights \\\"default\\\" \\n    -displayAppearance \\\"smoothShaded\\\" \\n    -activeOnly 0\\n    -ignorePanZoom 0\\n    -wireframeOnShaded 0\\n    -headsUpDisplay 1\\n    -holdOuts 1\\n    -selectionHiliteDisplay 1\\n    -useDefaultMaterial 0\\n    -bufferMode \\\"double\\\" \\n    -twoSidedLighting 0\\n    -backfaceCulling 0\\n    -xray 0\\n    -jointXray 0\\n    -activeComponentsXray 0\\n    -displayTextures 0\\n    -smoothWireframe 0\\n    -lineWidth 1\\n    -textureAnisotropic 0\\n    -textureHilight 1\\n    -textureSampling 2\\n    -textureDisplay \\\"modulate\\\" \\n    -textureMaxSize 32768\\n    -fogging 0\\n    -fogSource \\\"fragment\\\" \\n    -fogMode \\\"linear\\\" \\n    -fogStart 0\\n    -fogEnd 100\\n    -fogDensity 0.1\\n    -fogColor 0.5 0.5 0.5 1 \\n    -depthOfFieldPreview 1\\n    -maxConstantTransparency 1\\n    -rendererName \\\"vp2Renderer\\\" \\n    -objectFilterShowInHUD 1\\n    -isFiltered 0\\n    -colorResolution 256 256 \\n    -bumpResolution 512 512 \\n    -textureCompression 0\\n    -transparencyAlgorithm \\\"frontAndBackCull\\\" \\n    -transpInShadows 0\\n    -cullingOverride \\\"none\\\" \\n    -lowQualityLighting 0\\n    -maximumNumHardwareLights 1\\n    -occlusionCulling 0\\n    -shadingModel 0\\n    -useBaseRenderer 0\\n    -useReducedRenderer 0\\n    -smallObjectCulling 0\\n    -smallObjectThreshold -1 \\n    -interactiveDisableShadows 0\\n    -interactiveBackFaceCull 0\\n    -sortTransparent 1\\n    -controllers 1\\n    -nurbsCurves 1\\n    -nurbsSurfaces 1\\n    -polymeshes 1\\n    -subdivSurfaces 1\\n    -planes 1\\n    -lights 1\\n    -cameras 1\\n    -controlVertices 1\\n    -hulls 1\\n    -grid 1\\n    -imagePlane 1\\n    -joints 1\\n    -ikHandles 1\\n    -deformers 1\\n    -dynamics 1\\n    -particleInstancers 1\\n    -fluids 1\\n    -hairSystems 1\\n    -follicles 1\\n    -nCloths 1\\n    -nParticles 1\\n    -nRigids 1\\n    -dynamicConstraints 1\\n    -locators 1\\n    -manipulators 1\\n    -pluginShapes 1\\n    -dimensions 1\\n    -handles 1\\n    -pivots 1\\n    -textures 1\\n    -strokes 1\\n    -motionTrails 1\\n    -clipGhosts 1\\n    -bluePencil 1\\n    -greasePencils 0\\n    -shadows 0\\n    -captureSequenceNumber -1\\n    -width 1002\\n    -height 729\\n    -sceneRenderFilter 0\\n    $editorName;\\nmodelEditor -e -viewSelected 0 $editorName;\\nmodelEditor -e \\n    -pluginObjects \\\"gpuCacheDisplayFilter\\\" 1 \\n    $editorName\"\n"
		+ "\t\t\t\t$configName;\n\n            setNamedPanelLayout (localizedPanelLabel(\"Current Layout\"));\n        }\n\n        panelHistory -e -clear mainPanelHistory;\n        sceneUIReplacement -clear;\n\t}\n\n\ngrid -spacing 5 -size 12 -divisions 5 -displayAxes yes -displayGridLines yes -displayDivisionLines yes -displayPerspectiveLabels no -displayOrthographicLabels no -displayAxesBold yes -perspectiveLabelPosition axis -orthographicLabelPosition edge;\nviewManip -drawCompass 0 -compassAngle 0 -frontParameters \"\" -homeParameters \"\" -selectionLockParameters \"\";\n}\n");
	setAttr ".st" 3;
createNode script -n "sceneConfigurationScriptNode";
	rename -uid "8E4A03B4-4418-4571-F62F-E299C07C0496";
	setAttr ".b" -type "string" "playbackOptions -min 1 -max 120 -ast 1 -aet 200 ";
	setAttr ".st" 6;
select -ne :time1;
	setAttr ".o" 1;
	setAttr ".unw" 1;
select -ne :hardwareRenderingGlobals;
	setAttr ".otfna" -type "stringArray" 22 "NURBS Curves" "NURBS Surfaces" "Polygons" "Subdiv Surface" "Particles" "Particle Instance" "Fluids" "Strokes" "Image Planes" "UI" "Lights" "Cameras" "Locators" "Joints" "IK Handles" "Deformers" "Motion Trails" "Components" "Hair Systems" "Follicles" "Misc. UI" "Ornaments"  ;
	setAttr ".otfva" -type "Int32Array" 22 0 1 1 1 1 1
		 1 1 1 0 0 0 0 0 0 0 0 0
		 0 0 0 0 ;
	setAttr ".fprt" yes;
select -ne :renderPartition;
	setAttr -s 4 ".st";
select -ne :renderGlobalsList1;
select -ne :defaultShaderList1;
	setAttr -s 7 ".s";
select -ne :postProcessList1;
	setAttr -s 2 ".p";
select -ne :defaultRenderingList1;
select -ne :initialShadingGroup;
	setAttr ".ro" yes;
select -ne :initialParticleSE;
	setAttr ".ro" yes;
select -ne :defaultRenderGlobals;
	addAttr -ci true -h true -sn "dss" -ln "defaultSurfaceShader" -dt "string";
	setAttr ".ren" -type "string" "arnold";
	setAttr ".dss" -type "string" "lambert1";
select -ne :defaultResolution;
	setAttr ".pa" 1;
select -ne :defaultColorMgtGlobals;
	setAttr ".cfe" yes;
	setAttr ".cfp" -type "string" "<MAYA_RESOURCES>/OCIO-configs/Maya2022-default/config.ocio";
	setAttr ".vtn" -type "string" "ACES 1.0 SDR-video (sRGB)";
	setAttr ".vn" -type "string" "ACES 1.0 SDR-video";
	setAttr ".dn" -type "string" "sRGB";
	setAttr ".wsn" -type "string" "ACEScg";
	setAttr ".otn" -type "string" "ACES 1.0 SDR-video (sRGB)";
	setAttr ".potn" -type "string" "ACES 1.0 SDR-video (sRGB)";
select -ne :hardwareRenderGlobals;
	setAttr ".ctrs" 256;
	setAttr ".btrs" 512;
connectAttr ":defaultColorMgtGlobals.cme" "imagePlaneShape1.cme";
connectAttr ":defaultColorMgtGlobals.cfe" "imagePlaneShape1.cmcf";
connectAttr ":defaultColorMgtGlobals.cfp" "imagePlaneShape1.cmcp";
connectAttr ":defaultColorMgtGlobals.wsn" "imagePlaneShape1.ws";
connectAttr ":topShape.msg" "imagePlaneShape1.ltc";
relationship "link" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" "blinn1SG.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" "lambert2SG.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" "blinn1SG.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" "lambert2SG.message" ":defaultLightSet.message";
connectAttr "layerManager.dli[0]" "defaultLayer.id";
connectAttr "renderLayerManager.rlmi[0]" "defaultRenderLayer.rlid";
connectAttr ":defaultArnoldDisplayDriver.msg" ":defaultArnoldRenderOptions.drivers"
		 -na;
connectAttr ":defaultArnoldFilter.msg" ":defaultArnoldRenderOptions.filt";
connectAttr ":defaultArnoldDriver.msg" ":defaultArnoldRenderOptions.drvr";
connectAttr "blinn1.oc" "blinn1SG.ss";
connectAttr "blinn1SG.msg" "materialInfo1.sg";
connectAttr "blinn1.msg" "materialInfo1.m";
connectAttr "lambert2.oc" "lambert2SG.ss";
connectAttr "pCylinder4Shape.iog" "lambert2SG.dsm" -na;
connectAttr "lambert2SG.msg" "materialInfo2.sg";
connectAttr "lambert2.msg" "materialInfo2.m";
connectAttr "blinn1SG.pa" ":renderPartition.st" -na;
connectAttr "lambert2SG.pa" ":renderPartition.st" -na;
connectAttr "blinn1.msg" ":defaultShaderList1.s" -na;
connectAttr "lambert2.msg" ":defaultShaderList1.s" -na;
connectAttr "defaultRenderLayer.msg" ":defaultRenderingList1.r" -na;
// End of onion.ma
