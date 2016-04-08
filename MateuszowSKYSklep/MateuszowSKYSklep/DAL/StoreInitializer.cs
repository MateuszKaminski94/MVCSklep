﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using MateuszowSKYSklep.Models;

namespace MateuszowSKYSklep.DAL
{
    public class StoreInitializer : DropCreateDatabaseAlways<StoreContext>
    {
        protected override void Seed(StoreContext context)
        {
            SeedStoreData(context);

            base.Seed(context);
        }

        private void SeedStoreData(StoreContext context)
        {
            var genres = new List<Genre>
            {
                new Genre() {GenreId = 1, Name = "Akcji",IconFilename = "akcji.png"},
                new Genre() {GenreId = 2, Name = "Fabularne",IconFilename = "fabularne.png"},
                new Genre() {GenreId = 3, Name = "Indie",IconFilename = "indie.png"},
                new Genre() {GenreId = 4, Name = "Przygodowe",IconFilename = "przygodowe.png"},
                new Genre() {GenreId = 5, Name = "Sportowe",IconFilename = "sportowe.png"},
                new Genre() {GenreId = 6, Name = "Strategie",IconFilename = "strategie.png"},
                new Genre() {GenreId = 7, Name = "Strzelaniny",IconFilename = "strzelaniny.png"},
                new Genre() {GenreId = 8, Name = "Symulacje",IconFilename = "symulacje.png"}
            };

            genres.ForEach(g => context.Genres.Add(g));
            context.SaveChanges();

            var games = new List<Game>
            {
                new Game() {GameId = 1, DeveloperName = "Remedy Entertainment", GameTitle = "Alan Wake" , Price=35.78M, MainImageFilename = "1.png", IsPreOrder = true, DatePremiere = new DateTime(2012, 01, 16), GenreId = 1, Cpu = "Core 2 Duo 2 GHz", Ram="2 GB (4 GB - Vista/7)", Gpu="512 MB (GeForce 8800 lub lepsza)", Hdd = "8 GB", Os = "Windows XP/Vista/7", Source="http://www.gry-online.pl/S016.asp?ID=4961", Description = "Alan Wake stanowi kolejne dzieło ludzi odpowiedzialnych za popularną markę Max Payne. Całość stworzono w myśl konwencji psychologicznego thrillera akcji, a podczas developingu wyraźnie inspirowano się kultowym serialem telewizyjnym Davida Lyncha i Marka Frosta o nazwie Twin Peaks (Miasteczko Twin Peaks). Tytułowy bohater niniejszej gry jest autorem poczytnych powieści. Niestety od dwóch lat Alan nie potrafi napisać nowej książki. Żona pisarza, Alice, postanawia zabrać go na wakacje do malowniczego miasteczka Bright Falls, by odzyskał siły twórcze. Po początkowej sielance ukochana znika w niewyjaśnionych okolicznościach, a Wake wyrusza na jej poszukiwanie. Okazuje się, że Bright Falls to wcale nie bajkowa lokacja, lecz mroczne, pełne złych sił miejsce – jak to, w którym toczy się akcja ostatniego dzieła Alana, thrillera, którego napisania nie może sobie przypomnieć. Zabawa polega na poruszaniu się po wspomnianym miasteczku i jego okolicach, interakcji z mieszkańcami, odnajdywaniu fragmentów napisanej książki i walce bądź ucieczce przed przeciwnikami. W trakcie wyprawy odwiedzamy m.in. latarnię nad jeziorem i przedzieramy się przez gęsty las w górach. Przemieszczamy się zarówno piechotą, jak i za kierownicą kilku pojazdów, m.in. wysłużonego samochodu kombi. Przy okazji obserwujemy wyjątkowo realistyczne efekty pogodowe oraz cykl zmian pór doby. Nocą musimy uważać szczególnie, ponieważ właśnie wtedy materializują się przeróżne upiorne zjawiska, jak choćby opętani przez Mrok mieszkańcy Bright Falls. Przydaje się wówczas źródło światła (np. włączonej latarki, flary, reflektora itp.), które osłabia przeciwników i pozwala na zastosowanie broni palnej. Nietuzinkowy charakter gry podkreśla dopracowana oprawa wizualna. Trójwymiarowy świat prezentuje się bardzo sugestywnie, a gra świateł, nastrojowe efekty dźwiękowe i podkłady muzyczne, stanowią dodatkowy atut Alana Wake’a. W odróżnieniu od wydania na konsolę Xbox 360, edycja na komputery PC posiada od razu załączone dodatki DLC The Signal i The Writer. "},
                new Game() {GameId = 2, DeveloperName = "Ubisoft", GameTitle = "Rayman" , Price=5.39M, MainImageFilename = "2.png", IsPreOrder = false, DatePremiere = new DateTime(1996, 04, 30), GenreId = 1, Cpu = "486 33 MHz", Ram="4 MB", Gpu="-", Hdd = "700 MB", Os = "DOS/Windows 95", Source="http://www.gry-online.pl/S016.asp?ID=22954", Description = "Kolorowa side-scrollowa platformówka, w której, kierując sympatycznym Raymanem, ratujemy Krainę Snów przed potężnym i złowrogim Panem Złym. Wykreowana przez Michela Ancela i wydana przez Ubisoft produkcja, dała początek jednej z najdłuższych i najwyżej ocenianych serii zręcznościowych w historii. Gra zadebiutowała we wrześniu 1995 roku na konsolach PS One i Atari Jaguar, skąd została przeniesiona na szereg innych platform sprzętowych. Wspomniany Pan Zły (w oryginale Mr. Dark) podstępnie zaatakował baśniowy świat naszego bohatera i porwał jego mieszkańców – Electoonów, czyniąc ich swoimi niewolnikami. Ukradł też Wielkiego Protona, dzięki któremu na świecie panował ład i porządek, doprowadzając do chaosu i upadku całej krainy. Nie bacząc na czekające go niebezpieczeństwa, nasz protoplasta – sympatyczny stworek imieniem Rayman – wyrusza by pomóc uwięzionym mieszkańcom Krainy Snów i pokonać zagrażających światu przeciwników. W grze przyjdzie nam przemierzyć sześć różnych krain: Las Marzeń, Muzyczną Krainę, Niebieskie Góry, Obrazkowe Miasto, Jaskinie Skorpiona i Ciasteczkowy Zamek. Każda z nich podzielona jest na szereg etapów, w których prócz typowych przeszkód i pomniejszych przeciwników, czekają na nas również potężni bossowie – słudzy Pana Złego. Rayman przemierza rozmaite zakątki baśniowego świata, ratując pozamykanych w klatkach mieszkańców. W tej niebezpiecznej podróży pomocą naszemu bohaterowi służą napotykane postacie niezależne, które w zamian za pomoc obdarowują go rozmaitymi specjalnymi zdolnościami. Podczas gry Rayman nie tylko biega i skacze, lecz także wyprowadza super-mocne ciosy, fruwa przy pomocy pełniących rolę śmigiełka włosów, bądź też sadzi szybko-rosnące rośliny, odcinające drogę przeciwnikom. Pod względem technicznym mamy do czynienia z klasyczną side-scrollową platformówką. Dwuwymiarowa oprawa graficzna gry jest bajecznie kolorowa i wprost zalewa nas masą pastelowych barw i ogromem detali. Ścieżka dźwiękowa gry, stworzona w większości przez francuskiego muzyka Rémi Gazela uprzyjemnia zabawę i doskonale pasuje do klimatu rozgrywki. W 1997 roku Ubisoft wydał ulepszoną wersję gry Rayman Gold, w której wprowadzono szereg zmian w mechanice rozgrywki, dodając m.in. timer i konieczność zebrania 100 niebieskich kropek przed ukończeniem etapu. Prócz 24 oryginalnych poziomów gracze otrzymali zaawansowany edytor o nazwie Rayman Designer, pozwalający projektować własne levele i dzielić się nimi w internecie. Rok później ukazał się Rayman Forever, zawierający wersję Gold oraz pakiet 40 dodatkowych poziomów, stworzonych przez graczy."},
                new Game() {GameId = 3, DeveloperName = "Re-Logic", GameTitle = "Terraria" , Price=8.99M, MainImageFilename = "3.png", IsPreOrder = true, DatePremiere = new DateTime(2011, 05, 16), GenreId = 1, Cpu = "Pentium IV 1.6 GHz", Ram="512 MB (1 GB - Vista/7)", Gpu="128 MB (GeForce 7600 lub lepsza)", Hdd = "200 MB", Os = "Windows XP/Vista/7", Source="http://www.gry-online.pl/S016.asp?ID=16723", Description = "Terraria to platformówka 2D, w której gracze mogą do woli kreować otaczający ich świat. Produkcja niezależnego studia Re-Logic bywa nazywana dwuwymiarowym Minecraftem, bo pozwala graczom wpływać na przebieg rozgrywki. W grze przenosimy się do dwuwymiarowej krainy i otrzymujemy kilka podstawowych narzędzi. Od tej chwili jesteśmy zdani na siebie i własną pomysłowość. Podczas zabawy możemy kopać w ziemi i szukać surowców, sadzić rośliny, odkrywać nowe lokacje, walczyć z przeciwnikami, tworzyć obiekty, a także budować własne fortece, czy domy. Ogrom możliwości i zagrożeń sprawia, że każda rozgrywka jest nieco inna, bo kreuje ją sam gracz. Świat Terraria jest tworzony losowo, więc nigdy nie zwiedzamy tych samych lokacji. Prawie wszystkie elementy otoczenia da się zniszczyć lub usunąć – w ten sposób zbieramy materiały potrzebne do budowy oraz kształtujemy krajobraz. Przemierzając okolicę trzeba pamiętać o zapewnieniu sobie odpowiedniej ochrony przed licznymi przeciwnikami. Także w kwestii uzbrojenia wiele zależy od naszej wyobraźni – broń tworzymy samemu, a wybór jest zróżnicowany. W walce z goblinami, czy fruwającymi gałkami ocznymi korzystamy z mieczy, karabinów, granatów i dziesiątek innych pomysłowych gadżetów. Na spotkanie z unikalnym światem Terraria możemy wybrać się w pojedynkę lub w grupie znajomych. Zapraszając inne osoby do zabawy zyskujemy sprzymierzeńców w walce oraz pomocników przy budowaniu twierdz i innych obiektów. To sprawia, że całość nabiera nowego znaczenia i staje się jeszcze ciekawsza."},
                new Game() {GameId = 4, DeveloperName = "Starbreeze Studios", GameTitle = "Encalve" , Price=5.39M, MainImageFilename = "4.png", IsPreOrder = false, DatePremiere = new DateTime(2002, 07, 19), GenreId = 1, Cpu = "Pentium 4 1.7 GHz", Ram="256 MB", Gpu="32 MB (GeForce 3 Ti200 lub lepsza)", Hdd = "2.2 GB", Os = "Windows 95/98", Source="http://www.gry-online.pl/S016.asp?ID=1981", Description = "Enclave to gra akcji z elementami cRPG, z akcją osadzoną w świecie fantasy Celenheim. Swym wykonaniem przypomina Severance: Blade of Darkness. Świat Enclave w zamierzchłych czasach podzielony został na dwie części. Oba powstałe kontynenty zamieszkują dwie całkowicie skrajne i nienawidzące się nawzajem nacje, jedna dumnie nazywa się ludem Światła, druga zaś ludem Ciemności. Kraina Światła to ląd urodzajny, bogaty w dary natury i zamieszkały przez prawych obywateli, zaś ląd Ciemności to przeciwieństwo tego pierwszego - jałowa i nieurodzajna ziemia, pełna zła i plugastwa. Od wieków szczelina oddzielająca oba lądy skutecznie pełniła rolę rozjemcy obu społeczności, jednakże z upływem czasu zaczęła się zmniejszać. Zaowocowało to zwiększeniem się liczby potyczek pomiędzy dwoma nieprzepadającymi za sobą nacjami i w rezultacie napięcia osiągnęły stan, w którym wyniszczająca wojna była już tylko kwestią czasu. Gracz może opowiedzieć się po jednej ze stron konfliktu i wybrać jedną z dwunastu grywalnych postaci, takich jak Wolf Rider czy Elvin Archer, a następnie obserwować akcję zarówno z perspektywy pierwszej, jak i trzeciej osoby. Zależnie od dokonanego wyboru przygotowano dwie niezależne kampanie (po stronie dobra i zła), składające się łącznie z ponad dwudziestu rozległych , wypełnionych potworami poziomów, umiejscowionych w różnych starannie przygotowanych sceneriach. Akcja prowadzi nas przez takie miejsca jak ciemne komnaty zamczysk, groty pełne lawy i dymu oraz ośnieżone szczyty górskie. Podczas naszej przygody możemy wykorzystywać szereg rodzajów broni, m.in. mieczy, toporów, kusz, sztyletów oraz przedmiotów magicznych."},
                new Game() {GameId = 5, DeveloperName = "Red Barrels", GameTitle = "Outlast" , Price=17.89M, MainImageFilename = "5.png", IsPreOrder = true, DatePremiere = new DateTime(2013, 09, 4), GenreId = 1, Cpu = "Quad Core i5 2.8 GHz", Ram="3 GB", Gpu="1 GB (GeForce GTX 460 lub lepsza)", Hdd = "", Os = "Windows XP/Vista/7/8", Source="http://www.gry-online.pl/S016.asp?ID=19813", Description = "Outlast to pierwszoosobowy survival horror. Jest to debiutancki projekt zespołu Red Barrels, założonego przez ludzi, którzy pracowali wcześniej nad takimi seriami jak Prince of Persia, Assassin’s Creed, Splinter Cell oraz Uncharted. Akcja toczy w Stanach Zjednoczonych. Fabuła opowiada o losach zakładu dla obłąkanych, zlokalizowanego w stanie Kolorado. Przez długie lata budynek ten stał opuszczony, ale niedawno wykupiła go korporacja Murkoff, która otworzyła w tym miejscu ośrodek badawczy. W Outlast wcielamy się w dziennikarza o imieniu Miles Upshur, który dostaje cynk, że w zakładzie dzieją się dziwne rzeczy. Chcąc odkryć prawdę, włamuje się on do ośrodka i szybko odkrywa, że na miejscu przeprowadzane są nie tylko zakazane eksperymenty medyczne, ale również bluźniercze rytuały. Bez żadnej broni, wyposażony wyłącznie w kamerę i kilka zapasowych baterii, Miles wkracza do budynku, który wita go krwawymi scenami niedawnej masakry. Ktoś – lub coś – zabija pensjonariuszy i personel ośrodka, a jedyni żyjący świadkowie tych przerażających zbrodni są zbyt mocno zaburzeni, by służyć jakąkolwiek pomocą. Outlast czerpie pełnymi garściami z twórczości Clive’a Barkera i estetyki gore. Pełno w nim brutalności, krwi, wnętrzności, odrąbanych kończyn i poważnie okaleczonych ciał, jednak autorom udało się uniknąć przerysowania tych elementów. Duża w tym zasługa pozostawienia miejsca dla wyobraźni graczy - twórcy często korzystają z niedopowiedzeń, spotęgowanych za pomocą odpowiednio dobranych efektów dźwiękowych oraz mrocznej grafiki. Akcja gry ukazana jest z perspektywy pierwszej osoby. Tytuł łączy typowo przygodówkowe zwiedzanie lokacji i rozwiązywanie zagadek z elementami zręcznościowymi. Sekwencje akcji sprowadzają się głównie do uciekania oraz ukrywania przed nieprzyjaciółmi i w interesie gracza jest unikanie bezpośrednich konfrontacji. Wrogowie są nie tylko bezwzględni, ale również całkiem inteligentni i przeżycie spotkania z nawet jednym z nich wymaga sporo sprytu. Zagadki i zadania logiczne postawione przed graczem polegają głównie na odnajdywaniu przełączników i zaworów, a czasami również kluczy lub magnetycznych kart dostępu do drzwi. Grając w Outlasta, nie można zabłądzić, ponieważ fabuła jest liniowa. Dzięki temu zabiegowi gra nie traci na swojej dynamice."},
                new Game() {GameId = 6, DeveloperName = "Piranha Bytes", GameTitle = "Risen" , Price=8.99M, MainImageFilename = "6.png", IsPreOrder = false, DatePremiere = new DateTime(2009, 09, 2), GenreId = 1, Cpu = "Core 2 Duo 3 GHz", Ram="2 GB", Gpu="512 MB (GeForce 8800 lub lepsza)", Hdd = "2.5 GB", Os = "Windows XP/Vista", Source="http://www.gry-online.pl/S016.asp?ID=11997", Description = "Risen to stworzona przez studio Piranha Bytes gra z gatunku cRPG, będąca pierwszym projektem niemieckiej grupy od czasu wydania trzeciej odsłony Gothica. Produkt nie wiąże się w żaden sposób z sagą o przygodach Bezimiennego, gdyż nie pozwoliły na to prawa autorskie, pozostałe przy firmie JoWood. Akcja tytułu rozpoczyna się na wyspie, której centralnym punktem jest czynny wulkan. Wokół niego ukształtował się zróżnicowany krajobraz, w którym można dostrzec góry, tereny bagniste czy kamieniste wybrzeża. Obszar obfituje w zróżnicowane gatunki fauny i flory oraz liczne, przemieszczające się częstokroć w grupach potwory. Wulkaniczną wyspę zamieszkują też ludzie i przedstawiciele innych ras. Próżno jednak szukać tu orków, krasnoludów czy elfów. Gracz wciela się w postać zwykłego śmiertelnika, który stale uczy się, jak radzić sobie w niebezpiecznym świecie. Zadaniem bohatera jest eksploracja terenu i wykonywanie misji, które zlecają mu postacie niezależne (NPC) lub przywódcy frakcji obecnych na wyspie. Realizacja questów owocuje przyznaniem punktów doświadczenia oraz zapłatą w lokalnej walucie, za którą u handlarzy można kupić nowe typy broni albo jedzenie. Odnowienie zdrowia bohatera jest bowiem możliwe nie tylko za pomocą leczniczych mikstur, lecz również poprzez spożywanie posiłków i odpoczynek. Wraz z postępami w rozgrywce bohater otwiera kolejne rozdziały fabuły, które skłaniają go do zgłębiania umiejętności posługiwania się bronią jedno- i dwuręczną (mieczami, toporami, łukami itp.) oraz nauki zaklęć. Wydarzenia dziejące się w wirtualnym świecie sprawiają też, że od czasu do czasu heros komentuje swoje przeżycia krótkimi monologami. Sterowanie śmiałkiem odbywa się za pośrednictwem myszy i klawiatury. Bohaterowi towarzyszymy dzień i noc, obserwując przy tym zmienne warunki pogodowe i dopracowaną grafikę – sylwetki niektórych osób wykonano przy użyciu 6 tys. wielokątów, a do przedstawienia terenu wykorzystano technologię HDR. Całość warstwy technicznej dopełniono użyciem komercyjnych modułów w rodzaju silnika Ageia Physx oraz ścieżką dźwiękową, skomponowaną przez Kaiego Rosenkranza."},
                new Game() {GameId = 7, DeveloperName = "CD PROJEKT RED", GameTitle = "Witcher 3" , Price=39.99M, MainImageFilename = "7.png", IsPreOrder = true, DatePremiere = new DateTime(2015, 05, 19), GenreId = 2, Cpu = "i7-3770 3.4 GHz/AMD FX-8350 4 GHz", Ram="8 GB", Gpu="4 GB", Hdd = "40 GB", Os = "Windows 7/8/8.1 64-bit", Source="http://www.gry-online.pl/S016.asp?ID=20436", Description = "W grze Wiedźmin 3: Dziki Gon na PC Windows ponownie wcielamy się w znanego z wcześniejszych odsłon wiedźmina. Główna oś fabularna obraca się wokół kilku oddzielnych wątków. Wśród nich znalazło się poszukiwanie utraconej miłości Geralta oraz inwazja Nilfgaardu na Królestwa Północy. Spróbujemy też powstrzymać tytułowy Dziki Gon, prześladujący wiedźmina zarówno w powieściach, jak i obecny w pierwszej i w nikłym stopniu w drugiej części serii. Wszystkie te główne zadania oferują filmową jakość opowiadanej historii, z rozgałęzionymi ścieżkami wydarzeń, imponującymi scenkami przerywnikowymi i starannie wyreżyserowanymi sekwencjami. Co ciekawe, możemy porzucić część wątków, trzeba będzie jednak liczyć się z wynikającymi z tego faktu różnymi konsekwencjami. Poza głównymi opowieściami dostępne jest także zatrzęsienie misji pobocznych, które w sumie starczają na ponad sto godzin zabawy. Autorzy zadbali o dużą różnorodność wyzwań. W trakcie przygód będziemy eksplorowali m.in. jaskinie, prastare ruiny i tętniące życiem wioski. Zapolujemy na potwory dla zysku oraz specjalnych nagród. Pojawią się również zadania oparte na dochodzeniach. Biały Wilk może też oddać się rozgrywce w karcianego Gwinta, który jest odrębną grą w grze."},
                new Game() {GameId = 8, DeveloperName = "Piranha Bytes", GameTitle = "Gothic II" , Price=8.99M, MainImageFilename = "8.png", IsPreOrder = false, DatePremiere = new DateTime(2005, 11, 29), GenreId = 2, Cpu = "Pentium III 1.2 GHz", Ram="512 MB", Gpu="64 MB akcelerator 3D", Hdd = "2.2 GB", Os = "", Source="http://www.gry-online.pl/S016.asp?ID=1593", Description = "Sequel jednej z najlepszych gier akcji/cRPG roku 2001. Podobnie jak w części poprzedniej akcja Gothic II toczy się w świecie fantasy i kontynuuje fabułę poprzedniczki, tj. wojny pomiędzy siłami zła (cała masa potworów, Orków i Ogrów pod przewodnictwem Smoków) i Ludźmi. Jednak tym razem nie poruszamy się już tylko wewnątrz kolonii przestępców objętej zasięgiem magicznej bariery, a na jej zewnątrz. Akcja toczy się w nowych bardzo rozległych i różnorodnych lokacjach, m.in. miasteczko nadmorskie, klasztor, biblioteka, farma, Wyspa Smoków, zamek oblężony przez Orki. Oczywiście spotkamy tu też klika znajomych terenów. Praktycznie rzecz biorąc zasady gry nie uległy diametralnym zmianom. Mamy oczywiście kilka usprawnień, tj. nowe klasy postaci (m.in. magician, henchmen i dragon hunters), nowe gildie oraz nowe czynności które może wykonywać nasz bohater (m.in. tworzenie różnych mikstur). Nasza postać posiada szereg umiejętności, które może rozwijać, tj. kilka standardowych technik walki (single-handed, two-handed, bow oraz crossbow) oraz kilkanaście innych zdolności jak: creeping, lock picking, pick pocketing, creating runes, alchemy i forging. Ponadto może używać coraz silniejszych zaklęć wchodzących w skład sześciu kręgów magii. Całkowitym przeobrażeniom uległo komputerowe A.I. Dla przykładu teraz, zaatakowany mieszkaniec miasta wzywa straże, zaś wrogie potwory i bestie mogą ze sobą współpracować. Poprawie uległa też grafika - cała kraina i jej elementy (drzewa, miasta, domy, itp.) są bardziej dopracowane. W sumie w grze występuje około 100 różnych tekstur twarzy."},
                new Game() {GameId = 9, DeveloperName = "ASCARON Entertainment", GameTitle = "Sacred" , Price=22.38M, MainImageFilename = "9.png", IsPreOrder = false, DatePremiere = new DateTime(2004, 09, 22), GenreId = 2, Cpu = "Pentium 4 1.4 GHz", Ram="512 MB", Gpu="64 MB akcelerator 3D", Hdd = "2.5 GB", Os = "Windows 98/XP", Source="http://www.gry-online.pl/S016.asp?ID=1925", Description = "Gra z gatunku action/cRPG, za powstanie której odpowiada niemiecka firma Ascaron Entertainment, znana m.in. z takich tytułów jak: Port Royale i Patrician II: Quest for Power. Oferuje graczom, miłośnikom tego typu rozrywki, obszerny i różnorodny świat fantasy, Ancaria, składający się z szesnastu połączonych ze sobą i rządzących się własnymi zasadami regionów oraz rozbudowaną fabułę złożoną z ponad 30 głównych misji. Oprócz tego znajdziemy tu blisko 200 zadań pobocznych, których wykonanie nie ma bezpośredniego wpływu na wątek przewodni. Gracz ma dużą swobodę w zwiedzaniu świata gry - 70% lokacji dostępnych jest od samego początku, a pozostałe 30% odkrywa się w miarę wykonywania kolejnych zadań. Znajdziemy tu około 20 różnego typu otoczeń: lasy, tereny skute lodem, pustynie, góry, miasta, itd. Podróżując przez krainy natkniemy się na dużo różnorodnych przeciwników oraz NPC-ty, które dynamicznie reagują na nasze poczynania, np. po wykonaniu określonego zadania przydzielonego nam w danej krainie, zamieszkujący ją kupcy zaoferują nam lepsze ceny. Do naszej dyspozycji oddanych zostało sześć odmiennych klas postaci różniących się m.in. umiejętnościami i zdolnościami w walce (to: Gladiator, Wizard, Dark Elf, Forest Elf, Seraphim oraz Vampire Lady). Sacred oferuje intuicyjny i prosty w obsłudze system walki (do dziesięciu konfigurowalnych slotów akcji - dla broni, czarów i specjalnych ciosów), a poza opcją gry jednoosobowej istnieje możliwość gry wieloosobowej do 16 osób w sieci lokalnej i Internecie (dwa tryby: Co-operative i Hack 'n' Slay)."}
            };

            games.ForEach(h => context.Games.Add(h));
            context.SaveChanges();
        }
    }
}