using System;
using System.Collections.Generic;

bool programDziala = true;

while (programDziala)
{
    Console.WriteLine();
    Console.WriteLine("==========================================================");
    Console.WriteLine("   LABORATORIUM 05: KOLEKCJE W PĘTLI GRY (PPRG)           ");
    Console.WriteLine("==========================================================");
    Console.WriteLine("Poziom łatwy:");
    Console.WriteLine("  1 - Zadanie 1: Raport z pięciu tur (tablica)");
    Console.WriteLine("  2 - Zadanie 2: Lista ekwipunku (List<string>)");
    Console.WriteLine("  3 - Zadanie 3: Cennik kupca (Dictionary<string, int>)");
    Console.WriteLine("Poziom średni:");
    Console.WriteLine("  4 - Zadanie 4: Najlepsza i najgorsza wyprawa");
    Console.WriteLine("  5 - Zadanie 5: Bezpieczny wybór i usuwanie");
    Console.WriteLine("  6 - Zadanie 6: Magazyn przedmiotów");
    Console.WriteLine("Poziom trudny:");
    Console.WriteLine("  7 - Zadanie 7: Historia akcji z filtrowaniem");
    Console.WriteLine("  8 - Zadanie 8: Projekt — Hello Adventurer 5.0");
    Console.WriteLine("  9 - Zadanie 9: Projekt — Bestiariusz i statystyki walk");
    Console.WriteLine("  0 - Wyjście");
    Console.WriteLine("==========================================================");
    Console.Write("Wybierz zadanie (0-9): ");

    string? wyborZadania = Console.ReadLine();
    Console.WriteLine();

    switch (wyborZadania)
    {
        // =====================================================================
        // POZIOM ŁATWY — ZADANIE 1: Raport z pięciu tur
        // =====================================================================
        case "1":
        {
            Console.WriteLine("=== ZADANIE 1: Raport z pięciu tur ===");

            int[] zlotoWTurach = { 5, 12, 0, 8, 15 };

            if (zlotoWTurach.Length == 0)
            {
                Console.WriteLine("Tablica wyników jest pusta.");
            }
            else
            {
                // 1. Wyświetlenie wszystkich wyników w formacie "Tura 1: 5 sztuk złota" (pętla for)
                for (int i = 0; i < zlotoWTurach.Length; i++)
                {
                    Console.WriteLine($"Tura {i + 1}: {zlotoWTurach[i]} sztuk złota");
                }

                // 2. Obliczenie łącznej ilości złota oraz 4. policzenie tur >= 10 (pętla foreach)
                int sumaZlota = 0;
                int turyCoNajmniej10 = 0;

                foreach (int wynik in zlotoWTurach)
                {
                    sumaZlota += wynik;
                    if (wynik >= 10)
                    {
                        turyCoNajmniej10++;
                    }
                }

                // 3. Obliczenie średniej jako liczby typu double
                double sredniaZlota = (double)sumaZlota / zlotoWTurach.Length;

                Console.WriteLine();
                Console.WriteLine($"Łącznie: {sumaZlota}");
                Console.WriteLine($"Średnio na turę: {sredniaZlota:F2}");
                Console.WriteLine($"Tury z wynikiem co najmniej 10: {turyCoNajmniej10}");

                // 5. Wyświetlenie wyników od ostatniej tury do pierwszej
                Console.Write("Od końca: ");
                for (int i = zlotoWTurach.Length - 1; i >= 0; i--)
                {
                    Console.Write(zlotoWTurach[i]);
                    if (i > 0)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            // Odpowiedzi na pytania z zadania 1:
            // - Ostatni poprawny indeks tej tablicy to 4 (zlotoWTurach.Length - 1).
            // - Warunek ma postać i < zlotoWTurach.Length, ponieważ indeksowanie zaczyna się od 0,
            //   więc dla 5 elementów poprawne indeksy to 0, 1, 2, 3, 4 (indeks 5 wyszedłby poza zakres).
            // - Indeksu wymaga numerowanie tur (Tura 1..5) oraz wypisywanie od końca;
            //   przez foreach wygodnie wykonuje się sumowanie i zliczanie wartości >= 10.
            break;
        }

        // =====================================================================
        // POZIOM ŁATWY — ZADANIE 2: Lista ekwipunku
        // =====================================================================
        case "2":
        {
            Console.WriteLine("=== ZADANIE 2: Lista ekwipunku ===");

            List<string> plecak = new List<string>
            {
                "Miecz",
                "Mikstura",
                "Pochodnia"
            };

            // 1. Wyświetl liczbę przedmiotów oraz 2. pokaż wszystkie przedmioty z numerami od 1
            Console.WriteLine($"Plecak ({plecak.Count}/6):");
            if (plecak.Count == 0)
            {
                Console.WriteLine("Plecak jest pusty.");
            }
            else
            {
                for (int i = 0; i < plecak.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {plecak[i]}");
                }
            }

            Console.WriteLine();
            // 3. Pobierz nazwę nowego przedmiotu i dodaj go przez Add
            Console.Write("Znaleziony przedmiot: ");
            string? nowyPrzedmiot = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nowyPrzedmiot))
            {
                nowyPrzedmiot = "Klucz";
            }
            else
            {
                nowyPrzedmiot = nowyPrzedmiot.Trim();
            }

            plecak.Add(nowyPrzedmiot);
            Console.WriteLine($"Dodano: {nowyPrzedmiot}");

            // 4. Sprawdź przez Contains, czy w plecaku jest "Mikstura"
            if (plecak.Contains("Mikstura"))
            {
                Console.WriteLine("Sprawdzenie Contains: Mikstura znajduje się w plecaku.");
            }
            else
            {
                Console.WriteLine("Sprawdzenie Contains: W plecaku nie ma Mikstury.");
            }

            // 5. Spróbuj usunąć "Mikstura" przez Remove
            bool czyUsunieto = plecak.Remove("Mikstura");

            // 6. Na podstawie wyniku Remove wyświetl informację, czy operacja się udała
            if (czyUsunieto)
            {
                Console.WriteLine("Użyto mikstury.");
            }
            else
            {
                Console.WriteLine("Nie udało się użyć mikstury — brak w plecaku.");
            }

            Console.WriteLine();
            // 7. Ponownie pokaż zawartość oraz liczbę elementów
            Console.WriteLine($"Plecak ({plecak.Count}/6):");
            for (int i = 0; i < plecak.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {plecak[i]}");
            }

            break;
        }

        // =====================================================================
        // POZIOM ŁATWY — ZADANIE 3: Cennik kupca
        // =====================================================================
        case "3":
        {
            Console.WriteLine("=== ZADANIE 3: Cennik kupca ===");

            Dictionary<string, int> ceny = new Dictionary<string, int>
            {
                { "Mikstura", 15 },
                { "Pochodnia", 5 },
                { "Miecz", 40 }
            };

            // 1. Wyświetl liczbę pozycji za pomocą Count
            Console.WriteLine($"Liczba pozycji w cenniku: {ceny.Count}");

            // 2. Wyświetl wszystkie nazwy i ceny pętlą foreach, korzystając z Key i Value
            Console.WriteLine("Aktualny cennik:");
            foreach (KeyValuePair<string, int> pozycja in ceny)
            {
                Console.WriteLine($"- {pozycja.Key}: {pozycja.Value} szt. złota");
            }

            // 3. Pobierz od użytkownika nazwę przedmiotu
            Console.WriteLine();
            Console.Write("Podaj nazwę przedmiotu do sprawdzenia ceny: ");
            string? szukanaNazwa = Console.ReadLine();
            if (szukanaNazwa == null)
            {
                szukanaNazwa = "";
            }
            else
            {
                szukanaNazwa = szukanaNazwa.Trim();
            }

            // 4. Sprawdź ją przez ContainsKey i 5. wyświetl cenę albo komunikat
            if (ceny.ContainsKey(szukanaNazwa))
            {
                Console.WriteLine($"Cena przedmiotu '{szukanaNazwa}': {ceny[szukanaNazwa]} szt. złota");
            }
            else
            {
                Console.WriteLine($"Przedmiotu '{szukanaNazwa}' nie ma w cenniku.");
            }

            // 6. Zmień cenę mikstury na 12 przez ceny["Mikstura"] = 12
            ceny["Mikstura"] = 12;
            Console.WriteLine();
            Console.WriteLine("Zmieniono cenę Mikstury na 12 szt. złota.");

            // 7. Ponownie wyświetl cały cennik
            Console.WriteLine("Cennik po zmianie:");
            foreach (KeyValuePair<string, int> pozycja in ceny)
            {
                Console.WriteLine($"- {pozycja.Key}: {pozycja.Value} szt. złota");
            }

            // Wyjaśnienie: Odczyt ceny[nazwa] bez wcześniejszego sprawdzenia ContainsKey(nazwa)
            // rzuci wyjątek KeyNotFoundException i przerwie działanie programu, jeśli klucz nie istnieje.
            break;
        }

        // =====================================================================
        // POZIOM ŚREDNI — ZADANIE 4: Najlepsza i najgorsza wyprawa
        // =====================================================================
        case "4":
        {
            Console.WriteLine("=== ZADANIE 4: Najlepsza i najgorsza wyprawa ===");

            int liczbaTur = 0;
            bool poprawnaLiczbaTur = false;

            while (!poprawnaLiczbaTur)
            {
                Console.Write("Podaj liczbę tur (1–10): ");
                string? wejscieTur = Console.ReadLine();

                if (!int.TryParse(wejscieTur, out liczbaTur))
                {
                    Console.WriteLine("Błąd: wpisz liczbę całkowitą.");
                }
                else if (liczbaTur < 1 || liczbaTur > 10)
                {
                    Console.WriteLine("Błąd: liczba tur musi należeć do zakresu 1–10.");
                }
                else
                {
                    poprawnaLiczbaTur = true;
                }
            }

            int[] wynikiTur = new int[liczbaTur];

            for (int i = 0; i < wynikiTur.Length; i++)
            {
                bool poprawnyWynik = false;
                while (!poprawnyWynik)
                {
                    Console.Write($"Podaj złoto zdobyte w turze {i + 1}: ");
                    string? wejscieZloto = Console.ReadLine();

                    if (!int.TryParse(wejscieZloto, out int zlotoWTurze))
                    {
                        Console.WriteLine("Błąd: wpisz liczbę całkowitą.");
                    }
                    else if (zlotoWTurze < 0)
                    {
                        Console.WriteLine("Błąd: wynik nie może być ujemny.");
                    }
                    else
                    {
                        wynikiTur[i] = zlotoWTurze;
                        poprawnyWynik = true;
                    }
                }
            }

            // Obliczenia bez Min, Max, Sum i LINQ
            int suma = 0;
            int minimum = wynikiTur[0];
            int maksimum = wynikiTur[0];
            int pierwszaTuraMax = 1;
            int pierwszaTuraZero = -1;

            for (int i = 0; i < wynikiTur.Length; i++)
            {
                int wartosc = wynikiTur[i];
                suma += wartosc;

                if (wartosc < minimum)
                {
                    minimum = wartosc;
                }

                if (wartosc > maksimum)
                {
                    maksimum = wartosc;
                    pierwszaTuraMax = i + 1;
                }

                if (wartosc == 0 && pierwszaTuraZero == -1)
                {
                    pierwszaTuraZero = i + 1;
                }
            }

            int liczbaTurZMax = 0;
            for (int i = 0; i < wynikiTur.Length; i++)
            {
                if (wynikiTur[i] == maksimum)
                {
                    liczbaTurZMax++;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Suma: {suma}");
            Console.WriteLine($"Minimum: {minimum}");
            Console.WriteLine($"Maksimum: {maksimum}");
            Console.WriteLine($"Pierwszy najlepszy wynik: tura {pierwszaTuraMax}");
            Console.WriteLine($"Liczba tur z maksimum: {liczbaTurZMax}");

            if (pierwszaTuraZero != -1)
            {
                Console.WriteLine($"Pierwsza tura bez złota: {pierwszaTuraZero}");
            }
            else
            {
                Console.WriteLine("Pierwsza tura bez złota: brak (w każdej turze zdobyto złoto)");
            }

            break;
        }

        // =====================================================================
        // POZIOM ŚREDNI — ZADANIE 5: Bezpieczny wybór i usuwanie
        // =====================================================================
        case "5":
        {
            Console.WriteLine("=== ZADANIE 5: Bezpieczny wybór i usuwanie ===");

            List<string> przedmioty = new List<string>
            {
                "Miecz",
                "Tarcza",
                "Mikstura",
                "Klucz"
            };

            if (przedmioty.Count == 0)
            {
                Console.WriteLine("Lista przedmiotów jest pusta — nie można nic usunąć.");
            }
            else
            {
                for (int i = 0; i < przedmioty.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {przedmioty[i]}");
                }

                int wybranyNumer = 0;
                bool poprawnyWybor = false;

                while (!poprawnyWybor)
                {
                    Console.Write("Wybierz przedmiot do usunięcia: ");
                    string? wejscie = Console.ReadLine();

                    if (!int.TryParse(wejscie, out wybranyNumer))
                    {
                        Console.WriteLine("Wpisz liczbę całkowitą.");
                    }
                    else if (wybranyNumer < 1)
                    {
                        Console.WriteLine($"Numer musi należeć do zakresu 1–{przedmioty.Count}.");
                    }
                    else if (wybranyNumer > przedmioty.Count)
                    {
                        Console.WriteLine($"Numer musi należeć do zakresu 1–{przedmioty.Count}.");
                    }
                    else
                    {
                        poprawnyWybor = true;
                    }
                }

                // 1. Przelicz numer użytkownika na indeks
                int indeksDoUsuniecia = wybranyNumer - 1;

                // 2. Zapamiętaj nazwę usuwanego przedmiotu
                string usunietyPrzedmiot = przedmioty[indeksDoUsuniecia];

                // 3. Usuń go za pomocą RemoveAt
                przedmioty.RemoveAt(indeksDoUsuniecia);

                // 4. Wyświetl nazwę usuniętego przedmiotu
                Console.WriteLine($"Usunięto: {usunietyPrzedmiot}");

                // 5. Pokaż zaktualizowaną listę
                Console.WriteLine("Zaktualizowana lista przedmiotów:");
                if (przedmioty.Count == 0)
                {
                    Console.WriteLine("Lista jest teraz pusta.");
                }
                else
                {
                    for (int i = 0; i < przedmioty.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {przedmioty[i]}");
                    }
                }
            }

            // Wyjaśnienie: Używamy przedmioty.Count zamiast stałej liczby (np. 4), ponieważ
            // rozmiar listy może się zmieniać po dodaniu lub usunięciu elementów.
            break;
        }

        // =====================================================================
        // POZIOM ŚREDNI — ZADANIE 6: Magazyn przedmiotów
        // =====================================================================
        case "6":
        {
            Console.WriteLine("=== ZADANIE 6: Magazyn przedmiotów ===");

            Dictionary<string, int> magazyn = new Dictionary<string, int>
            {
                { "Mikstura", 3 },
                { "Pochodnia", 2 },
                { "Klucz", 1 }
            };

            bool magazynDziala = true;

            while (magazynDziala)
            {
                Console.WriteLine();
                Console.WriteLine("--- MENU MAGAZYNU ---");
                Console.WriteLine("1 - Pokaż magazyn");
                Console.WriteLine("2 - Przyjmij dostawę");
                Console.WriteLine("3 - Wydaj przedmiot");
                Console.WriteLine("4 - Usuń pustą pozycję");
                Console.WriteLine("5 - Zakończ");
                Console.Write("Wybierz opcję: ");

                string? opcjaMagazynu = Console.ReadLine();
                Console.WriteLine();

                switch (opcjaMagazynu)
                {
                    case "1":
                    {
                        if (magazyn.Count == 0)
                        {
                            Console.WriteLine("Magazyn jest pusty.");
                        }
                        else
                        {
                            Console.WriteLine($"Stan magazynu (liczba pozycji: {magazyn.Count}):");
                            foreach (KeyValuePair<string, int> wpis in magazyn)
                            {
                                Console.WriteLine($"- {wpis.Key}: {wpis.Value} szt.");
                            }
                        }
                        break;
                    }

                    case "2":
                    {
                        Console.Write("Podaj nazwę przedmiotu do dostawy: ");
                        string? nazwa = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(nazwa))
                        {
                            Console.WriteLine("Odmowa: nazwa przedmiotu nie może być pusta.");
                        }
                        else
                        {
                            nazwa = nazwa.Trim();
                            Console.Write("Podaj liczbę sztuk do przyjęcia: ");
                            string? iloscTekst = Console.ReadLine();

                            if (!int.TryParse(iloscTekst, out int ilosc) || ilosc <= 0)
                            {
                                Console.WriteLine("Odmowa: liczba przyjmowanych sztuk musi być dodatnią liczbą całkowitą.");
                            }
                            else
                            {
                                if (magazyn.ContainsKey(nazwa))
                                {
                                    magazyn[nazwa] += ilosc;
                                    Console.WriteLine($"Zwiększono stan '{nazwa}' o {ilosc}. Aktualny stan: {magazyn[nazwa]}.");
                                }
                                else
                                {
                                    magazyn.Add(nazwa, ilosc);
                                    Console.WriteLine($"Dodano nowy przedmiot '{nazwa}' w ilości {ilosc} szt.");
                                }
                            }
                        }
                        break;
                    }

                    case "3":
                    {
                        Console.Write("Podaj nazwę przedmiotu do wydania: ");
                        string? nazwa = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(nazwa))
                        {
                            Console.WriteLine("Odmowa: nazwa przedmiotu nie może być pusta.");
                        }
                        else
                        {
                            nazwa = nazwa.Trim();
                            if (!magazyn.ContainsKey(nazwa))
                            {
                                Console.WriteLine($"Odmowa: przedmiot '{nazwa}' nie istnieje w magazynie.");
                            }
                            else
                            {
                                Console.Write("Podaj liczbę sztuk do wydania: ");
                                string? iloscTekst = Console.ReadLine();

                                if (!int.TryParse(iloscTekst, out int ilosc) || ilosc <= 0)
                                {
                                    Console.WriteLine("Odmowa: liczba wydawanych sztuk musi być dodatnią liczbą całkowitą.");
                                }
                                else if (magazyn[nazwa] < ilosc)
                                {
                                    Console.WriteLine($"Odmowa: niewystarczający stan w magazynie (dostępne: {magazyn[nazwa]}, żądane: {ilosc}).");
                                }
                                else
                                {
                                    magazyn[nazwa] -= ilosc;
                                    Console.WriteLine($"Wydano {ilosc} szt. '{nazwa}'. Pozostało: {magazyn[nazwa]} szt.");
                                }
                            }
                        }
                        break;
                    }

                    case "4":
                    {
                        Console.Write("Podaj nazwę pozycji do usunięcia: ");
                        string? nazwa = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(nazwa))
                        {
                            Console.WriteLine("Odmowa: nazwa przedmiotu nie może być pusta.");
                        }
                        else
                        {
                            nazwa = nazwa.Trim();
                            if (!magazyn.ContainsKey(nazwa))
                            {
                                Console.WriteLine($"Odmowa: pozycja '{nazwa}' nie znajduje się w magazynie.");
                            }
                            else if (magazyn[nazwa] > 0)
                            {
                                Console.WriteLine($"Odmowa: nie można usunąć '{nazwa}', ponieważ stan wynosi {magazyn[nazwa]} (musi wynosić 0).");
                            }
                            else
                            {
                                magazyn.Remove(nazwa);
                                Console.WriteLine($"Usunięto pustą pozycję '{nazwa}' z magazynu.");
                            }
                        }
                        break;
                    }

                    case "5":
                    {
                        magazynDziala = false;
                        Console.WriteLine("Zamykanie magazynu.");
                        break;
                    }

                    default:
                    {
                        Console.WriteLine("Nieznana opcja menu magazynu.");
                        break;
                    }
                }
            }

            break;
        }

        // =====================================================================
        // POZIOM TRUDNY — ZADANIE 7: Historia akcji z filtrowaniem
        // =====================================================================
        case "7":
        {
            Console.WriteLine("=== ZADANIE 7: Historia akcji z filtrowaniem ===");

            List<string> historia = new List<string>();
            bool historiaDziala = true;

            while (historiaDziala)
            {
                Console.WriteLine();
                Console.WriteLine("1 - Eksploruj");
                Console.WriteLine("2 - Odpocznij");
                Console.WriteLine("3 - Znajdź przedmiot");
                Console.WriteLine("4 - Pokaż całą historię");
                Console.WriteLine("5 - Pokaż ostatnie trzy wpisy");
                Console.WriteLine("6 - Policz wybraną akcję");
                Console.WriteLine("7 - Wyczyść historię");
                Console.WriteLine("8 - Zakończ");
                Console.Write("Wybierz opcję: ");

                string? opcja = Console.ReadLine();
                Console.WriteLine();

                switch (opcja)
                {
                    case "1":
                        historia.Add("Eksploracja");
                        Console.WriteLine("Dodano wpis: Eksploracja");
                        break;

                    case "2":
                        historia.Add("Odpoczynek");
                        Console.WriteLine("Dodano wpis: Odpoczynek");
                        break;

                    case "3":
                        historia.Add("Znaleziono przedmiot");
                        Console.WriteLine("Dodano wpis: Znaleziono przedmiot");
                        break;

                    case "4":
                        if (historia.Count == 0)
                        {
                            Console.WriteLine("Historia akcji jest pusta.");
                        }
                        else
                        {
                            Console.WriteLine("Cała historia (od najstarszego do najnowszego):");
                            for (int i = 0; i < historia.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {historia[i]}");
                            }
                        }
                        break;

                    case "5":
                        if (historia.Count == 0)
                        {
                            Console.WriteLine("Historia akcji jest pusta.");
                        }
                        else
                        {
                            Console.WriteLine("Ostatnie (najwyżej trzy) wpisy historii:");
                            int indeksStartowy = historia.Count > 3 ? historia.Count - 3 : 0;
                            for (int i = indeksStartowy; i < historia.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {historia[i]}");
                            }
                        }
                        break;

                    case "6":
                        Console.Write("Podaj nazwę akcji do policzenia (np. Eksploracja / Odpoczynek / Znaleziono przedmiot): ");
                        string? szukanaAkcja = Console.ReadLine();
                        if (szukanaAkcja == null)
                        {
                            szukanaAkcja = "";
                        }
                        else
                        {
                            szukanaAkcja = szukanaAkcja.Trim();
                        }

                        int licznikWystapien = 0;
                        foreach (string wpis in historia)
                        {
                            if (wpis == szukanaAkcja)
                            {
                                licznikWystapien++;
                            }
                        }
                        Console.WriteLine($"Liczba wystąpień akcji '{szukanaAkcja}': {licznikWystapien}");
                        break;

                    case "7":
                        Console.Write("Czy na pewno chcesz wyczyścić historię? (t/n): ");
                        string? potwierdzenie = Console.ReadLine();
                        if (potwierdzenie != null && potwierdzenie.Trim().ToLower() == "t")
                        {
                            historia.Clear();
                            Console.WriteLine("Historia została wyczyszczona.");
                        }
                        else if (potwierdzenie != null && potwierdzenie.Trim().ToLower() == "n")
                        {
                            Console.WriteLine("Anulowano czyszczenie historii.");
                        }
                        else
                        {
                            Console.WriteLine("Nieprawidłowy wybór (wymagane 't' lub 'n'). Anulowano czyszczenie.");
                        }
                        break;

                    case "8":
                        historiaDziala = false;
                        Console.WriteLine("Zakończono zadanie 7.");
                        break;

                    default:
                        Console.WriteLine("Nieprawidłowa komenda. Spróbuj ponownie.");
                        break;
                }
            }

            break;
        }

        // =====================================================================
        // POZIOM TRUDNY — ZADANIE 8: Projekt — „Hello Adventurer 5.0: ekwipunek i dziennik”
        // =====================================================================
        case "8":
        {
            Console.Write("Podaj imię bohatera: ");
            string? imieBohatera = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(imieBohatera))
            {
                imieBohatera = "Nela";
            }
            else
            {
                imieBohatera = imieBohatera.Trim();
            }

            int punktyZycia = 80;
            int maksymalneZdrowie = 100;
            int zloto = 10;
            int numerTury = 1;
            int liczbaEksploracji = 0;
            bool graDziala = true;

            string[] znaleziska =
            {
                "Mikstura",
                "Klucz",
                "Pochodnia",
                "Zwój"
            };

            List<string> plecak = new List<string>
            {
                "Miecz",
                "Mikstura"
            };

            List<string> historia = new List<string>();
            int[] zlotoZdobyteWTurach = new int[20];
            int rozegraneTury = 0;
            string powodZakonczenia = "gracz wybrał wyjście.";

            while (graDziala)
            {
                Console.WriteLine();
                Console.WriteLine("=== HELLO ADVENTURER 5.0 ===");
                Console.WriteLine($"Tura: {numerTury}");
                Console.WriteLine($"Bohater: {imieBohatera}");
                Console.WriteLine($"Zdrowie: {punktyZycia}/{maksymalneZdrowie} | Złoto: {zloto} | Plecak: {plecak.Count}/6");
                Console.WriteLine();
                Console.WriteLine("1 - Eksploruj loch");
                Console.WriteLine("2 - Pokaż plecak");
                Console.WriteLine("3 - Użyj przedmiotu");
                Console.WriteLine("4 - Dodaj znalezisko");
                Console.WriteLine("5 - Wyrzuć przedmiot");
                Console.WriteLine("6 - Pokaż historię");
                Console.WriteLine("7 - Pokaż statystyki wyprawy");
                Console.WriteLine("8 - Zakończ grę");
                Console.Write("Twój wybór: ");

                string? akcja = Console.ReadLine();
                Console.WriteLine();

                bool turaZuzyta = false;

                switch (akcja)
                {
                    // 1 - Eksploruj loch
                    case "1":
                    {
                        punktyZycia -= 8;
                        if (punktyZycia < 0)
                        {
                            punktyZycia = 0;
                        }

                        zloto += 10;
                        liczbaEksploracji++;

                        int indeksTury = numerTury - 1;
                        if (indeksTury >= 0 && indeksTury < zlotoZdobyteWTurach.Length)
                        {
                            zlotoZdobyteWTurach[indeksTury] = 10;
                        }

                        historia.Add($"Tura {numerTury}: Eksploracja lochu (+10 złota, -8 HP).");
                        Console.WriteLine("Eksplorujesz loch! Zdobywasz 10 sztuk złota, ale tracisz 8 punktów życia.");
                        turaZuzyta = true;
                        break;
                    }

                    // 2 - Pokaż plecak
                    case "2":
                    {
                        if (plecak.Count == 0)
                        {
                            Console.WriteLine("Plecak jest pusty.");
                        }
                        else
                        {
                            Console.WriteLine($"Plecak ({plecak.Count}/6):");
                            for (int i = 0; i < plecak.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {plecak[i]}");
                            }

                            // Użycie Contains / IndexOf (wymaganie techniczne nr 6) oraz ręczne liczenie mikstur
                            int liczbaMikstur = 0;
                            foreach (string element in plecak)
                            {
                                if (element == "Mikstura")
                                {
                                    liczbaMikstur++;
                                }
                            }

                            int indeksPierwszejMikstury = plecak.IndexOf("Mikstura");
                            if (indeksPierwszejMikstury != -1)
                            {
                                Console.WriteLine($"Liczba mikstur w plecaku: {liczbaMikstur} (pierwsza na pozycji {indeksPierwszejMikstury + 1}).");
                            }
                            else
                            {
                                Console.WriteLine("Brak mikstur w plecaku.");
                            }
                        }
                        break;
                    }

                    // 3 - Użyj przedmiotu
                    case "3":
                    {
                        if (plecak.Count == 0)
                        {
                            Console.WriteLine("Plecak jest pusty — nie masz żadnego przedmiotu do użycia.");
                        }
                        else
                        {
                            Console.WriteLine("Wybierz przedmiot do użycia:");
                            for (int i = 0; i < plecak.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {plecak[i]}");
                            }

                            Console.Write("Podaj numer przedmiotu: ");
                            string? wejscieNumer = Console.ReadLine();

                            if (!int.TryParse(wejscieNumer, out int numerPrzedmiotu))
                            {
                                Console.WriteLine("Błąd: wpisz poprawną liczbę całkowitą.");
                            }
                            else if (numerPrzedmiotu < 1 || numerPrzedmiotu > plecak.Count)
                            {
                                Console.WriteLine($"Błąd: numer przedmiotu musi należeć do zakresu 1–{plecak.Count}.");
                            }
                            else
                            {
                                int indeks = numerPrzedmiotu - 1;
                                string wybranyPrzedmiot = plecak[indeks];

                                if (wybranyPrzedmiot == "Mikstura")
                                {
                                    int poprzednieZdrowie = punktyZycia;
                                    punktyZycia += 20;
                                    if (punktyZycia > maksymalneZdrowie)
                                    {
                                        punktyZycia = maksymalneZdrowie;
                                    }

                                    int przywrocone = punktyZycia - poprzednieZdrowie;
                                    plecak.RemoveAt(indeks);
                                    historia.Add($"Tura {numerTury}: Użyto Mikstury (przywrócono {przywrocone} HP).");
                                    Console.WriteLine($"Wypito miksturę! Zdrowie: {punktyZycia}/{maksymalneZdrowie}.");
                                    turaZuzyta = true;
                                }
                                else if (wybranyPrzedmiot == "Pochodnia")
                                {
                                    plecak.RemoveAt(indeks);
                                    historia.Add($"Tura {numerTury}: Rozświetlono korytarz.");
                                    Console.WriteLine("Rozświetlono korytarz.");
                                    turaZuzyta = true;
                                }
                                else if (wybranyPrzedmiot == "Zwój")
                                {
                                    zloto += 15;
                                    plecak.RemoveAt(indeks);
                                    historia.Add($"Tura {numerTury}: Użyto Zwoju (+15 złota).");
                                    Console.WriteLine("Odczytano starożytny zwój! Otrzymujesz 15 sztuk złota.");
                                    turaZuzyta = true;
                                }
                                else if (wybranyPrzedmiot == "Klucz" || wybranyPrzedmiot == "Miecz")
                                {
                                    Console.WriteLine($"Przedmiot '{wybranyPrzedmiot}' nie jest w tej wersji zużywany i pozostaje w plecaku.");
                                }
                                else
                                {
                                    Console.WriteLine($"Nieznany przedmiot '{wybranyPrzedmiot}' — pozostaje w plecaku.");
                                }
                            }
                        }
                        break;
                    }

                    // 4 - Dodaj znalezisko
                    case "4":
                    {
                        if (plecak.Count >= 6)
                        {
                            Console.WriteLine("Plecak jest pełny (6/6)! Nie możesz dodać nowego znaleziska.");
                        }
                        else
                        {
                            Console.WriteLine("Dostępne znaleziska:");
                            for (int i = 0; i < znaleziska.Length; i++)
                            {
                                Console.WriteLine($"{i + 1}. {znaleziska[i]}");
                            }

                            Console.Write("Wybierz numer znaleziska: ");
                            string? wejscieZnalezisko = Console.ReadLine();

                            if (!int.TryParse(wejscieZnalezisko, out int numerZnaleziska))
                            {
                                Console.WriteLine("Błąd: wpisz poprawną liczbę całkowitą.");
                            }
                            else if (numerZnaleziska < 1 || numerZnaleziska > znaleziska.Length)
                            {
                                Console.WriteLine($"Błąd: numer znaleziska musi należeć do zakresu 1–{znaleziska.Length}.");
                            }
                            else
                            {
                                int indeksZnaleziska = numerZnaleziska - 1;
                                string wybraneZnalezisko = znaleziska[indeksZnaleziska];

                                plecak.Add(wybraneZnalezisko);
                                historia.Add($"Tura {numerTury}: Dodano znalezisko '{wybraneZnalezisko}' do plecaka.");
                                Console.WriteLine($"Dodano do plecaka: {wybraneZnalezisko}.");
                                turaZuzyta = true;
                            }
                        }
                        break;
                    }

                    // 5 - Wyrzuć przedmiot
                    case "5":
                    {
                        if (plecak.Count == 0)
                        {
                            Console.WriteLine("Plecak jest pusty — nie ma czego wyrzucić.");
                        }
                        else
                        {
                            Console.WriteLine("Zawartość plecaka:");
                            for (int i = 0; i < plecak.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {plecak[i]}");
                            }

                            Console.Write("Wybierz numer przedmiotu do wyrzucenia: ");
                            string? wejscieWyrzuc = Console.ReadLine();

                            if (!int.TryParse(wejscieWyrzuc, out int numerWyrzuc))
                            {
                                Console.WriteLine("Błąd: wpisz poprawną liczbę całkowitą.");
                            }
                            else if (numerWyrzuc < 1 || numerWyrzuc > plecak.Count)
                            {
                                Console.WriteLine($"Błąd: numer musi należeć do zakresu 1–{plecak.Count}.");
                            }
                            else
                            {
                                int indeksWyrzuc = numerWyrzuc - 1;
                                string wyrzuconyPrzedmiot = plecak[indeksWyrzuc];
                                plecak.RemoveAt(indeksWyrzuc);

                                historia.Add($"Tura {numerTury}: Wyrzucono przedmiot '{wyrzuconyPrzedmiot}'.");
                                Console.WriteLine($"Wyrzucono z plecaka: {wyrzuconyPrzedmiot}.");
                                turaZuzyta = true;
                            }
                        }
                        break;
                    }

                    // 6 - Pokaż historię
                    case "6":
                    {
                        if (historia.Count == 0)
                        {
                            Console.WriteLine("Historia wydarzeń jest pusta.");
                        }
                        else
                        {
                            Console.WriteLine("Historia wydarzeń (od najstarszego do najnowszego):");
                            foreach (string wpis in historia)
                            {
                                Console.WriteLine($"- {wpis}");
                            }
                        }
                        break;
                    }

                    // 7 - Pokaż statystyki wyprawy
                    case "7":
                    {
                        Console.WriteLine("=== STATYSTYKI WYPRAWY ===");
                        Console.WriteLine($"Liczba eksploracji: {liczbaEksploracji}");

                        if (rozegraneTury == 0)
                        {
                            Console.WriteLine("Nie rozegrano jeszcze żadnej pełnej tury.");
                        }
                        else
                        {
                            int laczneZlotoEksploracji = 0;
                            int maxZlotoWTurze = zlotoZdobyteWTurach[0];
                            int turyBezZlota = 0;

                            for (int i = 0; i < rozegraneTury && i < zlotoZdobyteWTurach.Length; i++)
                            {
                                int zlotoWTurze = zlotoZdobyteWTurach[i];
                                laczneZlotoEksploracji += zlotoWTurze;

                                if (zlotoWTurze > maxZlotoWTurze)
                                {
                                    maxZlotoWTurze = zlotoWTurze;
                                }

                                if (zlotoWTurze == 0)
                                {
                                    turyBezZlota++;
                                }
                            }

                            Console.WriteLine($"Rozegrane tury: {rozegraneTury}");
                            Console.WriteLine($"Łączne złoto zdobyte podczas eksploracji: {laczneZlotoEksploracji}");
                            Console.WriteLine($"Największa ilość złota zdobyta w jednej turze: {maxZlotoWTurze}");
                            Console.WriteLine($"Liczba tur bez zdobytego złota: {turyBezZlota}");
                        }
                        break;
                    }

                    // 8 - Zakończ grę
                    case "8":
                    {
                        powodZakonczenia = "gracz wybrał wyjście.";
                        graDziala = false;
                        break;
                    }

                    default:
                    {
                        Console.WriteLine("Nieznana komenda. Wybierz opcję od 1 do 8.");
                        break;
                    }
                }

                // Sprawdzenie zużycia tury oraz warunków końca gry
                if (turaZuzyta)
                {
                    rozegraneTury++;

                    if (punktyZycia <= 0)
                    {
                        powodZakonczenia = "bohater stracił wszystkie punkty życia.";
                        graDziala = false;
                    }
                    else if (rozegraneTury >= 20)
                    {
                        powodZakonczenia = "osiągnięto limit 20 rozegranych tur.";
                        graDziala = false;
                    }
                    else
                    {
                        numerTury++;
                    }
                }
            }

            // Podsumowanie po zakończeniu gry
            Console.WriteLine();
            Console.WriteLine("=== PODSUMOWANIE ===");
            Console.WriteLine($"Bohater: {imieBohatera}");
            Console.WriteLine($"Rozegrane tury: {rozegraneTury}");
            Console.WriteLine($"Eksploracje: {liczbaEksploracji}");
            Console.WriteLine($"Zdrowie: {punktyZycia}/{maksymalneZdrowie}");
            Console.WriteLine($"Złoto: {zloto}");
            Console.WriteLine($"Przedmioty w plecaku: {plecak.Count}");
            Console.WriteLine($"Wpisy w historii: {historia.Count}");
            Console.WriteLine($"Powód zakończenia: {powodZakonczenia}");

            Console.WriteLine();
            Console.WriteLine("Ostateczna zawartość plecaka:");
            if (plecak.Count == 0)
            {
                Console.WriteLine("Plecak jest pusty.");
            }
            else
            {
                for (int i = 0; i < plecak.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {plecak[i]}");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Ostatnie wpisy historii (najwyżej 3):");
            if (historia.Count == 0)
            {
                Console.WriteLine("Brak wpisów w historii.");
            }
            else
            {
                int startHistorii = historia.Count > 3 ? historia.Count - 3 : 0;
                for (int i = startHistorii; i < historia.Count; i++)
                {
                    Console.WriteLine($"- {historia[i]}");
                }
            }

            break;
        }

        // =====================================================================
        // POZIOM TRUDNY — ZADANIE 9: Projekt — bestiariusz i statystyki walk
        // =====================================================================
        case "9":
        {
            Console.WriteLine("=== ZADANIE 9: Projekt — Bestiariusz i statystyki walk ===");

            Dictionary<string, int> punktyZycia = new Dictionary<string, int>();
            Dictionary<string, int> liczbaPokonanych = new Dictionary<string, int>();

            bool bestiariuszDziala = true;

            while (bestiariuszDziala)
            {
                Console.WriteLine();
                Console.WriteLine("--- MENU BESTIARIUSZA ---");
                Console.WriteLine("1 - Dodaj gatunek");
                Console.WriteLine("2 - Wyświetl bestiariusz");
                Console.WriteLine("3 - Zarejestruj zwycięstwo");
                Console.WriteLine("4 - Zmień punkty życia gatunku");
                Console.WriteLine("5 - Usuń gatunek z obu słowników");
                Console.WriteLine("6 - Wyszukaj gatunek");
                Console.WriteLine("7 - Pokaż raport");
                Console.WriteLine("8 - Zakończ");
                Console.Write("Wybierz opcję: ");

                string? wyborMenu = Console.ReadLine();
                Console.WriteLine();

                switch (wyborMenu)
                {
                    // 1 - Dodaj gatunek
                    case "1":
                    {
                        Console.Write("Podaj nazwę gatunku przeciwnika: ");
                        string? gatunek = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(gatunek))
                        {
                            Console.WriteLine("Błąd: nazwa gatunku nie może być pusta.");
                        }
                        else
                        {
                            gatunek = gatunek.Trim();
                            if (punktyZycia.ContainsKey(gatunek))
                            {
                                Console.WriteLine($"Odmowa: gatunek '{gatunek}' już istnieje w bestiariuszu.");
                            }
                            else
                            {
                                Console.Write("Podaj bazowe punkty życia (dodatnia liczba całkowita): ");
                                string? hpTekst = Console.ReadLine();
                                if (!int.TryParse(hpTekst, out int hp) || hp <= 0)
                                {
                                    Console.WriteLine("Błąd: punkty życia muszą być dodatnią liczbą całkowitą.");
                                }
                                else
                                {
                                    punktyZycia.Add(gatunek, hp);
                                    liczbaPokonanych.Add(gatunek, 0);
                                    Console.WriteLine($"Dodano gatunek '{gatunek}' (HP: {hp}, pokonanych: 0).");
                                }
                            }
                        }
                        break;
                    }

                    // 2 - Wyświetl bestiariusz
                    case "2":
                    {
                        if (punktyZycia.Count == 0)
                        {
                            Console.WriteLine("Bestiariusz jest pusty.");
                        }
                        else
                        {
                            Console.WriteLine($"Bestiariusz (liczba gatunków: {punktyZycia.Count}):");
                            foreach (KeyValuePair<string, int> wpis in punktyZycia)
                            {
                                string klucz = wpis.Key;
                                int hp = wpis.Value;
                                int pokonani = liczbaPokonanych.ContainsKey(klucz) ? liczbaPokonanych[klucz] : 0;
                                Console.WriteLine($"- {klucz} | Bazowe HP: {hp} | Pokonanych: {pokonani}");
                            }
                        }
                        break;
                    }

                    // 3 - Zarejestruj zwycięstwo
                    case "3":
                    {
                        Console.Write("Podaj nazwę pokonanego gatunku: ");
                        string? gatunek = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(gatunek))
                        {
                            Console.WriteLine("Błąd: nazwa gatunku nie może być pusta.");
                        }
                        else
                        {
                            gatunek = gatunek.Trim();
                            if (!liczbaPokonanych.ContainsKey(gatunek))
                            {
                                Console.WriteLine($"Odmowa: gatunek '{gatunek}' nie występuje w bestiariuszu.");
                            }
                            else
                            {
                                Console.Write("Podaj liczbę pokonanych przeciwników (domyślnie 1): ");
                                string? ileTekst = Console.ReadLine();
                                int ile = 1;
                                bool poprawneIle = true;

                                if (!string.IsNullOrWhiteSpace(ileTekst))
                                {
                                    if (!int.TryParse(ileTekst, out ile) || ile <= 0)
                                    {
                                        poprawneIle = false;
                                    }
                                }

                                if (!poprawneIle)
                                {
                                    Console.WriteLine("Błąd: liczba pokonanych musi być dodatnią liczbą całkowitą.");
                                }
                                else
                                {
                                    liczbaPokonanych[gatunek] += ile;
                                    Console.WriteLine($"Zarejestrowano zwycięstwo nad '{gatunek}' (+{ile}). Łącznie pokonanych: {liczbaPokonanych[gatunek]}.");
                                }
                            }
                        }
                        break;
                    }

                    // 4 - Zmień punkty życia
                    case "4":
                    {
                        Console.Write("Podaj nazwę gatunku do zmiany HP: ");
                        string? gatunek = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(gatunek))
                        {
                            Console.WriteLine("Błąd: nazwa gatunku nie może być pusta.");
                        }
                        else
                        {
                            gatunek = gatunek.Trim();
                            if (!punktyZycia.ContainsKey(gatunek))
                            {
                                Console.WriteLine($"Odmowa: gatunek '{gatunek}' nie istnieje w bestiariuszu.");
                            }
                            else
                            {
                                Console.Write("Podaj nową wartość punktów życia: ");
                                string? noweHpTekst = Console.ReadLine();
                                if (!int.TryParse(noweHpTekst, out int noweHp) || noweHp <= 0)
                                {
                                    Console.WriteLine("Błąd: punkty życia muszą być dodatnią liczbą całkowitą.");
                                }
                                else
                                {
                                    punktyZycia[gatunek] = noweHp;
                                    Console.WriteLine($"Zmieniono punkty życia gatunku '{gatunek}' na {noweHp}.");
                                }
                            }
                        }
                        break;
                    }

                    // 5 - Usuń gatunek z obu słowników
                    case "5":
                    {
                        Console.Write("Podaj nazwę gatunku do usunięcia: ");
                        string? gatunek = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(gatunek))
                        {
                            Console.WriteLine("Błąd: nazwa gatunku nie może być pusta.");
                        }
                        else
                        {
                            gatunek = gatunek.Trim();
                            if (!punktyZycia.ContainsKey(gatunek) || !liczbaPokonanych.ContainsKey(gatunek))
                            {
                                Console.WriteLine($"Odmowa: gatunek '{gatunek}' nie znajduje się w bestiariuszu.");
                            }
                            else
                            {
                                punktyZycia.Remove(gatunek);
                                liczbaPokonanych.Remove(gatunek);
                                Console.WriteLine($"Usunięto gatunek '{gatunek}' z obu słowników.");
                            }
                        }
                        break;
                    }

                    // 6 - Wyszukaj gatunek
                    case "6":
                    {
                        Console.Write("Podaj nazwę szukanego gatunku: ");
                        string? gatunek = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(gatunek))
                        {
                            Console.WriteLine("Błąd: nazwa gatunku nie może być pusta.");
                        }
                        else
                        {
                            gatunek = gatunek.Trim();
                            if (punktyZycia.ContainsKey(gatunek) && liczbaPokonanych.ContainsKey(gatunek))
                            {
                                Console.WriteLine($"Znaleziono: {gatunek} | Bazowe HP: {punktyZycia[gatunek]} | Pokonanych: {liczbaPokonanych[gatunek]}");
                            }
                            else
                            {
                                Console.WriteLine($"Gatunek '{gatunek}' nie został znaleziony w bestiariuszu.");
                            }
                        }
                        break;
                    }

                    // 7 - Pokaż raport (bez LINQ)
                    case "7":
                    {
                        if (punktyZycia.Count == 0)
                        {
                            Console.WriteLine("Raport niedostępny — bestiariusz jest pusty.");
                        }
                        else
                        {
                            int liczbaGatunkow = punktyZycia.Count;
                            int laczniePokonanych = 0;
                            int sumaHp = 0;
                            int maxPokonanych = -1;
                            string najczesciejPokonywany = "";
                            List<string> niepokonaneGatunki = new List<string>();

                            foreach (KeyValuePair<string, int> wpisHp in punktyZycia)
                            {
                                string gatunek = wpisHp.Key;
                                int hp = wpisHp.Value;
                                sumaHp += hp;

                                int pokonani = 0;
                                if (liczbaPokonanych.ContainsKey(gatunek))
                                {
                                    pokonani = liczbaPokonanych[gatunek];
                                }

                                laczniePokonanych += pokonani;

                                if (pokonani > maxPokonanych)
                                {
                                    maxPokonanych = pokonani;
                                    najczesciejPokonywany = gatunek;
                                }
                                else if (pokonani == maxPokonanych && maxPokonanych > 0)
                                {
                                    najczesciejPokonywany += ", " + gatunek;
                                }

                                if (pokonani == 0)
                                {
                                    niepokonaneGatunki.Add(gatunek);
                                }
                            }

                            double srednieHp = (double)sumaHp / liczbaGatunkow;

                            Console.WriteLine("=== RAPORT BESTIARIUSZA ===");
                            Console.WriteLine($"Liczba gatunków: {liczbaGatunkow}");
                            Console.WriteLine($"Łączna liczba pokonanych przeciwników: {laczniePokonanych}");

                            if (maxPokonanych > 0)
                            {
                                Console.WriteLine($"Najczęściej pokonywany gatunek: {najczesciejPokonywany} (wynik: {maxPokonanych})");
                            }
                            else
                            {
                                Console.WriteLine("Najczęściej pokonywany gatunek: brak (żaden przeciwnik nie został jeszcze pokonany)");
                            }

                            Console.WriteLine($"Średnia liczba punktów życia: {srednieHp:F2}");

                            if (niepokonaneGatunki.Count == 0)
                            {
                                Console.WriteLine("Gatunki jeszcze niepokonane: brak (wszystkie gatunki pokonano co najmniej raz).");
                            }
                            else
                            {
                                Console.Write("Gatunki jeszcze niepokonane: ");
                                for (int i = 0; i < niepokonaneGatunki.Count; i++)
                                {
                                    Console.Write(niepokonaneGatunki[i]);
                                    if (i < niepokonaneGatunki.Count - 1)
                                    {
                                        Console.Write(", ");
                                    }
                                }
                                Console.WriteLine();
                            }
                        }
                        break;
                    }

                    // 8 - Zakończ
                    case "8":
                    {
                        bestiariuszDziala = false;
                        Console.WriteLine("Zamykanie bestiariusza.");
                        break;
                    }

                    default:
                    {
                        Console.WriteLine("Nieznana komenda. Wybierz opcję 1–8.");
                        break;
                    }
                }
            }

            break;
        }

        case "0":
        {
            programDziala = false;
            Console.WriteLine("Do zobaczenia!");
            break;
        }

        default:
        {
            Console.WriteLine("Nieznana opcja. Wybierz numer zadania od 0 do 9.");
            break;
        }
    }
}
