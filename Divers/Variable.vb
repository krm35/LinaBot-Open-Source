﻿
Module Variable

    ' refonte à faire / Non fini

    Public Comptes As New List(Of Player)

    Public DicoServeur As New Dictionary(Of String, sServeur)
    Public DicoPersonnage As New Dictionary(Of String, sPersonnage)
    Public DicoItems As New Dictionary(Of Integer, sItems)
    Public DicoSort As New Dictionary(Of Integer, Dictionary(Of Integer, sSort)) 'ID sort puis Level fini par les infos sort.
    Public DicoDivers As New Dictionary(Of Integer, sInterraction)
    Public DicoMobs As New Dictionary(Of Integer, Dictionary(Of Integer, sMobs))
    Public DicoPNJ As New Dictionary(Of Integer, String)
    Public DicoMaison As New Dictionary(Of Integer, sMaison)
    Public DicoPnjReponse As New Dictionary(Of Integer, String)
    Public DicoMétier As New Dictionary(Of Integer, sMetier)
    Public DicoDragodindeId As New Dictionary(Of Integer, String) From
        {
        {1, "Amande Sauvage"},
        {3, "Ebene"},
        {6, "Rousse Sauvage"},
        {9, "Ebene et Ivoire"},
        {10, "Rousse"},
        {11, "Ivoire et Rousse"},
        {12, "Ebene et Rousse"},
        {15, "Turquoise"},
        {16, "Ivoire"},
        {17, "Indigo"},
        {18, "Doree"},
        {19, "Pourpre"},
        {20, "Amande"},
        {21, "Emeraude"},
        {22, "Orchidee"},
        {23, "Prune"},
        {33, "Amande et Doree"},
        {34, "Amande et Ebene"},
        {35, "Amande et Emeraude"},
        {36, "Amande et Indigo"},
        {37, "Amande et Ivoire"},
        {38, "Amande et Rousse"},
        {39, "Amande et Turquoise"},
        {40, "Amande et Orchidee"},
        {41, "Amande et Pourpre"},
        {42, "Doree et Ebene"},
        {43, "Doree et Emeraude"},
        {44, "Doree et Indigo"},
        {45, "Doree et Ivoire"},
        {46, "Doree et Rousse"},
        {47, "Doree et Turquoise"},
        {48, "Doree et Orchidee"},
        {49, "Doree et Pourpre"},
        {50, "Ebene et Emeraude"},
        {51, "Ebene et Indigo"},
        {52, "Ebene et Turquoise"},
        {53, "Ebene et Orchidee"},
        {54, "Ebene et Pourpre"},
        {55, "Emeraude et Indigo"},
        {56, "Emeraude et Ivoire"},
        {57, "Emeraude et Rousse"},
        {58, "Emeraude et Turquoise"},
        {59, "Emeraude et Orchidee"},
        {60, "Emeraude et Pourpre"},
        {61, "Indigo et Ivoire"},
        {62, "Indigo et Rousse"},
        {63, "Indigo et Turquoise"},
        {64, "Indigo et Orchidee"},
        {65, "Indigo et Pourpre"},
        {66, "Ivoire et Turquoise"},
        {67, "Ivoire et Orchidee"},
        {68, "Ivoire et Pourpre"},
        {69, "Turquoise et Rousse"},
        {70, "Orchidee et Rousse"},
        {71, "Pourpre et Rousse"},
        {72, "Turquoise et Orchidee"},
        {73, "Turquoise et Pourpre"},
        {74, "Doree Sauvage"},
        {76, "Orchidee et Pourpre"},
        {77, "Prune et Amande"},
        {78, "Prune et Doree"},
        {79, "Prune et Ebene"},
        {80, "Prune et Emeraude"},
        {82, "Prune et Indigo"},
        {83, "Prune et Ivoire"},
        {84, "Prune et Rousse"},
        {85, "Prune et Turquoise"},
        {86, "Prune et Orchidee"},
        {87, "Prune et Pourpre"},
        {88, "En Armure"},
        {89, "a Plumes"}
        }

    Public Liste_Archimonstre As New List(Of Integer) From {2354, 2336, 2310, 2315, 2316, 2357, 2312, 2341, 2342, 2344, 2345, 2347, 2327, 2574, 2343, 2355, 2356, 2323, 2348, 2393, 2313, 2352,
                                                            2487, 2522, 2332, 2317, 2520, 2371, 2331, 2286, 2402, 2318, 2293, 2294, 2358, 2314, 2494, 2541, 2292, 2301, 2353, 2427, 2431, 2302,
                                                            2399, 2400, 2396, 2401, 2430, 2334, 2549, 2349, 2325, 2298, 2304, 2397, 2411, 2324, 2378, 2295, 2548, 2437, 2346, 2338, 2340, 2272,
                                                            2297, 2532, 2413, 2484, 2333, 2533, 2542, 2296, 2416, 2403, 2440, 2277, 2335, 2417, 2424, 2425, 2426, 2326, 2529, 2329, 2486, 2379,
                                                            2376, 2305, 2321, 2436, 2416, 2309, 2521, 2280, 2281, 2282, 2283, 2276, 2404, 2405, 2406, 2407, 2408, 2432, 2615, 2421, 2339, 2299,
                                                            2385, 2319, 2439, 2350, 2285, 2465, 2415, 2557, 2558, 2559, 2560, 2328, 2392, 2311, 2498, 2308, 2420, 2384, 2391, 2433, 2493, 2508,
                                                            2525, 2539, 2540, 2585, 2289, 2573, 2320, 2322, 2423, 2442, 2568, 2517, 2616, 2524, 2575, 2582, 2583, 2584, 2279, 2389, 2438, 2592,
                                                            2422, 2556, 2359, 2593, 2502, 2507, 2505, 2506, 2590, 2581, 2273, 2589, 2555, 2369, 2368, 2451, 2367, 2453, 2459, 2455, 2457, 2527,
                                                            2287, 2510, 2591, 2351, 2434, 2419, 2538, 2377, 2372, 2450, 2449, 2513, 2516, 2509, 2518, 2275, 2588, 2554, 2466, 2467, 2563, 2468,
                                                            2545, 2579, 2561, 2547, 2428, 2474, 2476, 2473, 2475, 2472, 2503, 2580, 2337, 2598, 2571, 2572, 2448, 2447, 2446, 2445, 2461, 2497,
                                                            2412, 2543, 2306, 2511, 2388, 2414, 2482, 2495, 2515, 2271, 2270, 2386, 2429, 2577, 2398, 2464, 2452, 2562, 2550, 2546, 2360, 2565,
                                                            2519, 2514, 2528, 2534, 2363, 2307, 2566, 2569, 2361, 2544, 2454, 2456, 2458, 2460, 2278, 2512, 2526, 2462, 2567, 2531, 2383, 2300,
                                                            2587, 2570, 2382, 2381, 2578, 2553, 2303, 2601, 2552, 2370, 2469, 2373, 2551, 2600, 2471, 2374, 2597, 2614, 2564, 2483, 2477, 2470}

    Public DicoFamilier As New Dictionary(Of Integer, Dictionary(Of String, sFamilier))

    Public LuaScript As New NLua.Lua

    Public ListOfMap(13000) As String



#Region "Structure"

    Structure sServeur

        Dim NomServeur As String
        Dim IP As String
        Dim Port As Integer
        Dim IdServeur As String

    End Structure

    Structure sPersonnage

        Dim ID As Integer
        Dim NomClasse As String
        Dim Sexe As String

    End Structure

    Structure sItems

        Dim ID As String
        Dim NomItem As String
        Dim Catégorie As String
        Dim Pods As String

    End Structure

    Structure sSort

        Dim IDSort As Integer
        Dim Level As Integer
        Dim Nom As String
        Dim POMin As Integer
        Dim POMax As Integer
        Dim PA As Integer
        Dim NbrLancerTour As Integer
        Dim NbrLancerTourJoueur As Integer
        Dim NbrLancerEntreTour As Integer
        Dim POModifiable As Boolean
        Dim LigneDeVue As Boolean
        Dim LancerEnLigne As Boolean
        Dim CelluleLibre As Boolean
        Dim ECFiniTour As Boolean
        Dim ZoneMin As Integer
        Dim ZoneMax As Integer
        Dim ChampAction As String
        Dim CoûtUp As Integer
        Dim SortClasse As String
        Dim Définition As String

    End Structure

    Structure sInterraction

        Dim IdSprite As Integer
        Dim Nom As String
        Dim DicoInterraction As Dictionary(Of String, Integer)

    End Structure

    Structure sMobs

        Dim ID As Integer
        Dim NomMobs As String
        Dim Level As Integer
        Dim RésistanceNeutre As Integer
        Dim RésistanceTerre As Integer
        Dim RésistanceFeu As Integer
        Dim RésistanceEau As Integer
        Dim RésistanceAir As Integer
        Dim EsquivePA As Integer
        Dim EsquivePM As Integer

    End Structure

    Structure sMaison

        Dim Nom As String
        Dim Map As String
        Dim CellulePorte As String
        Dim MapId As String

    End Structure

    Structure sMetier

        Dim IdMetier As Integer
        Dim NomMetier As String
        Dim Atelier As Dictionary(Of Integer, String())

    End Structure

    Structure sFamilier

        Dim Nourriture As List(Of Integer)
        Dim IntervaleRepasMin As Integer
        Dim IntervaleRepasMax As Integer
        Dim CapacitéNormal As Integer
        Dim CapacitéMax As Integer

    End Structure



#End Region

End Module
