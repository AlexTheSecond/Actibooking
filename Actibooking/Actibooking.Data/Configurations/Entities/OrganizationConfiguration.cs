﻿using Actibooking.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actibooking.Data.Configurations.Entities
{
    public class OrganizationConfiguration : IEntityTypeConfiguration<Organization>
    {
        public void Configure(EntityTypeBuilder<Organization> builder)
        {
            builder.HasData(
                new Organization(1, "Podwodna Piratka", true, "Szkółka nauki pływania Podwodna Piratka oferuje profesjonalne lekcje pływania dla dzieci w wieku od 3 do 12 lat. Nasze doświadczeni instruktorzy zapewnią bezpieczną i przyjemną atmosferę, dzięki czemu twoje dziecko szybko nauczy się pływać i czerpać radość z wody.", "/Img/Organization/1.jpg", "8a7236c7-2aba-4a45-a0ea-76cfd64c362e", 1, 2),
new Organization(2, "Aqua Swim", true, "Szkoła pływania Aqua Swim to miejsce, w którym każdy, bez względu na wiek czy umiejętności, może nauczyć się pływać. Nasza kadra składa się z wykwalifikowanych instruktorów, którzy zapewnią indywidualne podejście do każdego ucznia. Organizujemy też zajęcia grupowe dla dzieci i dorosłych.", "/Img/Organization/2.jpg", "8d00408d-dd7d-4653-95de-6d557d15cba2", 2, 49),
new Organization(3, "Fajna Fala", true, "Fajna Fala to szkoła pływania, która oferuje zajęcia dla dzieci, młodzieży i dorosłych. Nasze lekcje odbywają się w przyjaznej i kameralnej atmosferze, a naszym priorytetem jest zapewnienie bezpieczeństwa oraz komfortu naszym uczniom. Nasza kadra to doświadczeni instruktorzy, którzy z przyjemnością pomogą ci osiągnąć twoje pływackie cele.", "/Img/Organization/3.jpg", "8f45952d-18dd-4104-be74-3a64bedd7732", 3, 98),
new Organization(4, "Akademia Piłkarska", true, "Szkółka piłkarska Akademia Piłkarska to miejsce, w którym młodzi zawodnicy mogą rozwijać swoje umiejętności pod okiem wykwalifikowanych trenerów. Nasze zajęcia odbywają się na nowoczesnym boisku ze sztuczną nawierzchnią, a nasz program treningowy jest dostosowany do potrzeb i możliwości każdego zawodnika.", "/Img/Organization/4.jpg", "96670e83-96b2-4794-890f-8ec696031e5a", 4, 45),
new Organization(5, "Szkółka Piłkarska FUTSAL Team", true, "Szkółka Piłkarska FUTSAL Team to miejsce, w którym nauczymy Twoje dziecko gry w futsal – dynamicznej i szybkiej odmianie piłki nożnej. Nasze zajęcia odbywają się na specjalnie przygotowanej hali, a nasz zespół trenerów to doświadczeni futsaliści z wieloletnim stażem.", "/Img/Organization/5.jpg", "99f936ad-f124-475f-a905-37dfa7af2dd7", 5, 76),
new Organization(6, "Elite Football Academy", true, "Elite Football Academy to luksusowa szkółka piłkarska, która oferuje najwyższej jakości treningi dla młodych zawodników. Nasze boisko jest wyposażone w najnowocześniejszy sprzęt, a nasz program treningowy opiera się na najskuteczniejszych metodach szkolenia. U nas Twoje dziecko będzie mogło rozwijać swoje umiejętności w profesjonalnych warunkach.", "/Img/Organization/6.jpg", "a3a5f26a-478d-4cec-b232-4c4fbb4f2fc9", 6, 103),
new Organization(7, "FitLife", true, "Klub fitness to miejsce, gdzie możesz zadbać o swoją sylwetkę i zdrowie. Znajdziesz tam nowoczesne sprzęty do ćwiczeń, a także fachową pomoc i wsparcie trenerów.", "/Img/Organization/7.jpg", "a738ce28-e5ad-464b-af44-310fd1690298", 7, 110),
new Organization(8, "Body Factory", true, "Nasz klub fitness oferuje szeroki wybór zajęć grupowych, w tym zumbę, aerobik i jogi. Do dyspozycji naszych klientów jest też sauna i basen, dzięki czemu mogą oni zrelaksować się po intensywnym treningu.", "/Img/Organization/8.jpg", "b3e61492-c8a0-4dd3-8603-e6dd8a03ab23", 8, 16),
new Organization(9, "Power Gym", true, "Jeśli chcesz poprawić swoją wydolność i kondycję, zapraszamy do naszego klubu fitness. Znajdziesz tam nowoczesne sprzęty treningowe, a także zajęcia z trenerami personalnymi, dzięki którym osiągniesz swoje cele fitness.", "/Img/Organization/9.jpg", "bfbc9756-e531-4f43-b28c-95def4eee14f", 9, 83),
new Organization(10, "Akrobatyczna Szkółka Gimnastyczna", true, "Szkółka gimnastyczna to miejsce, gdzie dzieci i młodzież mogą rozwijać swoje umiejętności gimnastyczne pod okiem wykwalifikowanych trenerów. Nasza szkółka oferuje zajęcia z różnych dyscyplin gimnastycznych, takich jak gimnastyka artystyczna, sportowa i akrobatyczna.", "/Img/Organization/10.jpg", "c1299e92-aaa9-4075-98c4-7147edba4982", 10, 64),
new Organization(11, "Gimnastyczne Skrzydła", true, "Zapraszamy do naszej szkółki gimnastycznej, gdzie nasi młodzi zawodnicy mogą rozwijać swoje umiejętności i pasje. Oferujemy zajęcia dla dzieci w różnym wieku, a także dla zaawansowanych zawodników, którzy chcą startować w zawodach.", "/Img/Organization/11.jpg", "d20cb05b-a51a-4fce-a0de-deb5a9ece8d3", 11, 137),
new Organization(12, "Szkółka Artystycznej Gimnastyki", true, "Nasza szkółka gimnastyczna to miejsce, gdzie dzieci i młodzież mogą rozwijać swoje umiejętności i pasje gimnastyczne. Oferujemy szeroki wybór zajęć, w tym gimnastykę artystyczną, sportową i akrobatyczną. Do dyspozycji naszych zawodników jest nowoczesna sala gimnastyczna i sprzęt treningowy.", "/Img/Organization/12.jpg", "d7a85f80-e0b9-4d86-8c0a-09c6d6ffa512", 12, 29),
new Organization(13, "Trener personalny Ewa", true, "Trener personalny to osoba, która pomaga innym osiągać ich cele fitness. Mogą oni dostarczać indywidualnych planów treningowych, pomóc w doborze odpowiedniej diety i motywować do regularnego wykonywania ćwiczeń.", "/Img/Organization/13.jpg", "e244c2ab-b2b4-416f-9f07-15c522004141", 13, 134),
new Organization(14, "Trener personalny Adam", true, "Trener personalny to osoba z wiedzą i doświadczeniem w dziedzinie fitness, która pomaga klientom poprawiać ich zdrowie i kondycję fizyczną poprzez indywidualnie dopasowane plany treningowe i diety. Trenerzy personalni mogą pracować z różnymi grupami wiekowymi i poziomami zaawansowania.", "/Img/Organization/14.jpg", "ec0437d5-653c-47c5-91a3-af138f3bf41a", 14, 20),
new Organization(15, "Trener personalny Karolina", true, "Trener personalny to profesjonalista, który pomaga osobom osiągać ich cele fitness poprzez stworzenie indywidualnego programu treningowego i diety. Trenerzy personalni często posiadają specjalistyczne certyfikaty i szkolenia, aby zapewnić swoim klientom najlepsze wyniki. Oni także mogą dostarczyć wskazówki i wsparcie emocjonalne w trakcie całego procesu treningowego.", "/Img/Organization/15.jpg", "f0973431-1adf-423d-983a-9483c2a83da0", 15, 72),
new Organization(16, "Rehab Center", true, "Ośrodek rehabilitacyjny to miejsce, gdzie można uzyskać profesjonalną pomoc w przywróceniu sprawności fizycznej po urazach lub chorobach. Nasz ośrodek oferuje szeroki zakres usług rehabilitacyjnych, w tym masaże, ćwiczenia fizjoterapeutyczne i terapię zajęciową.", "/Img/Organization/16.jpg", "f09d3fff-bd88-48db-85f4-268ceb850a2a", 16, 112),
new Organization(17, "Ośrodek Rehabilitacji Ruchowej", true, "Zapraszamy do naszego ośrodka rehabilitacyjnego, gdzie nasi wykwalifikowani specjaliści pomogą Ci wrócić do pełnej sprawności po urazie lub chorobie. Oferujemy kompleksowe usługi rehabilitacyjne, w tym zabiegi fizjoterapeutyczne, masaże i terapię zajęciową.", "/Img/Organization/17.jpg", "f7565c67-17e5-4ee7-8ba4-1680019cbb8f", 17, 32),
new Organization(18, "Szpitalna Rehabilitacja", true, "Jeśli potrzebujesz pomocy w powrocie do zdrowia po urazie lub chorobie, zapraszamy do naszego ośrodka rehabilitacyjnego. Oferujemy szeroki zakres usług rehabilitacyjnych, w tym ćwiczenia fizjoterapeutyczne, masaże i terapię zajęciową. Nasz zespół to wykwalifikowani specjaliści, którzy pomogą Ci osiągnąć maksymalną sprawność.", "/Img/Organization/18.jpg", "fef73609-37f0-42f9-9517-c182fd53af85", 18, 106),
new Organization(19, "Koszykarska Akademia", true, "Szkółka koszykarska to miejsce, gdzie młodzi adepci koszykówki mogą rozwijać swoje umiejętności i pasje pod okiem wykwalifikowanych trenerów. Nasza szkółka oferuje zajęcia dla dzieci i młodzieży w różnym wieku oraz na różnych poziomach zaawansowania.", "/Img/Organization/19.jpg", "7497e83a-f729-4296-82f3-222758286730", 19, 15),
new Organization(20, "Młode Orły Koszykówki", true, "Zapraszamy do naszej szkółki koszykarskiej, gdzie nasi młodzi zawodnicy mogą rozwijać swoje umiejętności i pasje. Oferujemy zajęcia dla dzieci w różnym wieku, a także dla zaawansowanych zawodników, którzy chcą startować w zawodach.", "/Img/Organization/20.jpg", "74fee782-a90b-4d7f-b229-380dbd65117f", 20, 26),
new Organization(21, "Koszykarska Szkoła Mistrzów", true, "Nasza szkółka koszykarska to miejsce, gdzie dzieci i młodzież mogą rozwijać swoje umiejętności i pasje koszykarskie. Oferujemy szeroki wybór zajęć, w tym treningi indywidualne i grupowe oraz możliwość udziału w turniejach i meczach. Do dyspozycji naszych zawodników jest nowoczesna hala sportowa i profesjonalny sprzęt treningowy.", "/Img/Organization/21.jpg", "7a4a4199-5159-42d1-9c02-d70b741d7f07", 21, 108),
new Organization(22, "Złote Strzały", true, "Szkołka hokejowa Złote Strzały oferuje zajęcia dla dzieci w wieku od 6 do 12 lat. Naszym celem jest rozwijanie umiejętności hokejowych oraz kształtowanie postaw sportowych u naszych młodych zawodników. Nasz szkoleniowiec ma wieloletnie doświadczenie i jest w stanie dostosować treningi do indywidualnych potrzeb każdego uczestnika.", "/Img/Organization/22.jpg", "7a642938-fd22-4b65-935f-5c616ab88666", 22, 109),
new Organization(23, "Hokejowa Akademia Młodych Orłów", true, "Hokejowa Akademia Młodych Orłów to miejsce, w którym nasi najmłodsi zawodnicy mogą rozwijać swoje umiejętności pod okiem wykwalifikowanej kadry trenerskiej. Prowadzimy zajęcia dla dzieci w wieku od 8 do 14 lat, a nasz program treningowy jest oparty na indywidualnym podejściu do każdego zawodnika.", "/Img/Organization/23.jpg", "7dff1713-4e6d-4ef3-b992-606e7de605ef", 23, 24),
new Organization(24, "Hokejowa Szkoła Mistrzów", true, "Hokejowa Szkoła Mistrzów to miejsce, w którym każdy młody zawodnik może rozwijać swoje umiejętności i spełniać swoje marzenia o karierze hokejowej. Nasza szkołka skupia się na rozwoju umiejętności technicznych i taktycznych, a także na budowaniu wiary w siebie i współpracy w zespole. Prowadzimy zajęcia dla dzieci w wieku od 5 do 12 lat.", "/Img/Organization/24.jpg", "8a7236c7-2aba-4a45-a0ea-76cfd64c362e", 24, 12),
new Organization(25, "Piłka w Dłoni", true, "Szkółka piłki ręcznej to miejsce, gdzie młodzi adepci tego sportu mogą rozwijać swoje umiejętności i pasje pod okiem wykwalifikowanych trenerów. Nasza szkółka oferuje zajęcia dla dzieci i młodzieży w różnym wieku oraz na różnych poziomach zaawansowania.", "/Img/Organization/25.jpg", "8d00408d-dd7d-4653-95de-6d557d15cba2", 25, 62),
new Organization(26, "Szkoła Piłki Ręcznej Dla Dzieci", true, "Zapraszamy do naszej szkółki piłki ręcznej, gdzie nasi młodzi zawodnicy mogą rozwijać swoje umiejętności i pasje. Oferujemy zajęcia dla dzieci w różnym wieku, a także dla zaawansowanych zawodników, którzy chcą startować w zawodach.", "/Img/Organization/26.jpg", "8f45952d-18dd-4104-be74-3a64bedd7732", 26, 62),
new Organization(27, "Mistrzostwo w Piłce Ręcznej", true, "Nasza szkółka piłki ręcznej to miejsce, gdzie dzieci i młodzież mogą rozwijać swoje umiejętności i pasje związane z piłką ręczną. Oferujemy szeroki wybór zajęć, w tym treningi indywidualne i grupowe oraz możliwość udziału w turniejach i meczach. Do dyspozycji naszych zawodników jest nowoczesna hala sportowa i profesjonalny sprzęt treningowy.", "/Img/Organization/27.jpg", "96670e83-96b2-4794-890f-8ec696031e5a", 27, 82),
new Organization(28, "Taniec Marzeń", true, "Szkoła tańca Taniec Marzeń oferuje szeroką gamę kursów tańca dla dzieci, młodzieży i dorosłych. Nasi wykwalifikowani instruktorzy pomogą Ci rozwinąć swoje umiejętności tańca i poczuć radość z ruchu.", "/Img/Organization/28.jpg", "99f936ad-f124-475f-a905-37dfa7af2dd7", 28, 60),
new Organization(29, "Szkoła Tańca z Klasą", true, "Szkoła Tańca z Klasą to miejsce, w którym możesz nauczyć się tańczyć wszystkie ulubione style, od salsa po hip-hop. Nasze zajęcia są prowadzone przez doświadczonych tancerzy i choreografów, a atmosfera w grupie jest przyjazna i kreatywna.", "/Img/Organization/29.jpg", "a3a5f26a-478d-4cec-b232-4c4fbb4f2fc9", 29, 74),
new Organization(30, "Taniec to radość", true, "Taniec to radość to szkoła tańca, w której nauczysz się tańczyć z pasją i poziomem. Oferujemy zajęcia indywidualne i grupowe, a nasze lekcje są dostosowane do potrzeb i umiejętności każdego uczestnika. Dołącz do nas i poznaj radość tańca!", "/Img/Organization/30.jpg", "a738ce28-e5ad-464b-af44-310fd1690298", 30, 133),
new Organization(31, "Narciarska Akademia", true, "Szkółka narciarska to miejsce, gdzie młodzi adepci narciarstwa mogą rozwijać swoje umiejętności i pasje pod okiem wykwalifikowanych instruktorów. Nasza szkółka oferuje zajęcia dla dzieci i młodzieży w różnym wieku oraz na różnych poziomach zaawansowania.", "/Img/Organization/31.jpg", "b3e61492-c8a0-4dd3-8603-e6dd8a03ab23", 31, 122),
new Organization(32, "Szkoła Mistrzów Białego Szaleństwa", true, "Zapraszamy do naszej szkółki narciarskiej, gdzie nasi młodzi zawodnicy mogą rozwijać swoje umiejętności i pasje. Oferujemy zajęcia dla dzieci w różnym wieku, a także dla zaawansowanych zawodników, którzy chcą startować w zawodach.", "/Img/Organization/32.jpg", "bfbc9756-e531-4f43-b28c-95def4eee14f", 32, 101),
new Organization(33, "Narciarska Przyszłość", true, "Nasza szkółka narciarska to miejsce, gdzie dzieci i młodzież mogą rozwijać swoje umiejętności i pasje związane z narciarstwem. Oferujemy szeroki wybór zajęć, w tym treningi na stoku narciarskim i w hali, a także możliwość udziału w zawodach i kursach instruktorskich. Do dyspozycji naszych zawodników jest profesjonalny sprzęt narciarski i nowoczesna baza treningowa.", "/Img/Organization/33.jpg", "c1299e92-aaa9-4075-98c4-7147edba4982", 33, 41),
new Organization(34, "Crossfit Iron Will", true, "Crossfit Iron Will to miejsce, gdzie można znaleźć profesjonalną i wszechstronną opiekę treningową. Nasz zespół trenerów posiada wieloletnie doświadczenie i specjalizuje się w prowadzeniu zajęć zgodnych z filozofią crossfitu.", "/Img/Organization/34.jpg", "d20cb05b-a51a-4fce-a0de-deb5a9ece8d3", 34, 27),
new Organization(35, "Crossfit Alpha Wolf", true, "W Crossfit Alpha Wolf oferujemy unikalne treningi oparte na metodzie crossfit, która łączy w sobie elementy wielu dyscyplin sportowych. Naszym celem jest poprawa kondycji fizycznej i wzmocnienie całego ciała poprzez różnorodne ćwiczenia.", "/Img/Organization/35.jpg", "d7a85f80-e0b9-4d86-8c0a-09c6d6ffa512", 35, 88),
new Organization(36, "Crossfit Rise Up", true, "Crossfit Rise Up to przestrzeń, w której każdy może rozwijać swoje umiejętności i osiągać indywidualne cele treningowe. Nasz klub oferuje szeroki wybór zajęć grupowych oraz indywidualnych sesji z trenerem, aby zapewnić najlepsze efekty treningowe.", "/Img/Organization/36.jpg", "e244c2ab-b2b4-416f-9f07-15c522004141", 36, 119),
new Organization(37, "Klub Karate Złoty Dzwon", true, "Klub Karate Złoty Dzwon oferuje profesjonalne treningi karate dla dzieci, młodzieży i dorosłych. Nasze zajęcia prowadzone są przez wykwalifikowanych instruktorów, którzy pomogą Ci rozwinąć umiejętności i osiągnąć sukces w tej sztuce walki.", "/Img/Organization/37.jpg", "ec0437d5-653c-47c5-91a3-af138f3bf41a", 37, 65),
new Organization(38, "Klub Karate Samuraj", true, "Klub Karate Samuraj to miejsce, w którym możesz nauczyć się tradycyjnego japońskiego karate. Nasze zajęcia są prowadzone w miłej i przyjaznej atmosferze, a naszym celem jest rozwijanie ciała i ducha poprzez treningi karate.", "/Img/Organization/38.jpg", "f0973431-1adf-423d-983a-9483c2a83da0", 38, 124),
new Organization(39, "Klub Karate Siła i Harmonii", true, "Klub Karate Siła i Harmonii to szkoła karate, w której nauczysz się technik i zasad tej sztuki walki. Oferujemy zajęcia dla wszystkich poziomów zaawansowania, a naszym celem jest rozwijanie umiejętności i kształtowanie charakteru poprzez treningi karate.", "/Img/Organization/39.jpg", "f09d3fff-bd88-48db-85f4-268ceb850a2a", 39, 35),
new Organization(40, "MMA Fighters Club", true, "Klub MMA to miejsce, gdzie można rozwijać swoje umiejętności w różnych dyscyplinach walki, takich jak boks, jiu-jitsu, karate i kickboxing. Nasz klub oferuje zajęcia z trenerami personalnymi oraz możliwość udziału w zawodach i turniejach.", "/Img/Organization/40.jpg", "f7565c67-17e5-4ee7-8ba4-1680019cbb8f", 40, 92),
new Organization(41, "Total Fight Academy", true, "Zapraszamy do naszego klubu MMA, gdzie nasi wykwalifikowani trenerzy pomogą Ci rozwinąć swoje umiejętności w różnych dyscyplinach walki. Oferujemy zajęcia indywidualne i grupowe, a także możliwość trenowania z zawodowymi zawodnikami.", "/Img/Organization/41.jpg", "fef73609-37f0-42f9-9517-c182fd53af85", 41, 116),
new Organization(42, "Mixed Martial Arts Gym", true, "Jeśli chcesz rozwinąć swoje umiejętności w różnych dyscyplinach walki, zapraszamy do naszego klubu MMA. Oferujemy szeroki wybór zajęć, w tym boks, jiu-jitsu, karate i kickboxing. Nasz zespół to wykwalifikowani trenerzy, którzy pomogą Ci osiągnąć maksymalne rezultaty.", "/Img/Organization/42.jpg", "7497e83a-f729-4296-82f3-222758286730", 42, 39),
new Organization(43, "Szkoła Samoobrony", true, "Szkoła samoobrony to miejsce, gdzie można nauczyć się technik i technik obrony w sytuacjach kryzysowych. Nasza szkoła oferuje zajęcia z różnych dyscyplin samoobrony, takich jak krav maga, judo i aikido, a także szkolenia z pierwszej pomocy.", "/Img/Organization/43.jpg", "74fee782-a90b-4d7f-b229-380dbd65117f", 43, 70),
new Organization(44, "Akademia Samoobrony", true, "Zapraszamy do naszej szkoły samoobrony, gdzie nasi wykwalifikowani instruktorzy pomogą Ci nauczyć się technik obrony w sytuacjach zagrożenia. Oferujemy zajęcia dla osób w różnym wieku i na różnych poziomach zaawansowania, a także możliwość udziału w turniejach i zawodach.", "/Img/Organization/44.jpg", "7a4a4199-5159-42d1-9c02-d70b741d7f07", 44, 94),
new Organization(45, "Szkoła Walki i Samoobrony", true, "Jeśli chcesz nauczyć się technik samoobrony, zapraszamy do naszej szkoły. Oferujemy szeroki wybór zajęć, w tym krav maga, judo i aikido, a także szkolenia z pierwszej pomocy. Nasz zespół to wykwalifikowani instruktorzy, którzy pomogą Ci osiągnąć maksymalne rezultaty.", "/Img/Organization/45.jpg", "7a642938-fd22-4b65-935f-5c616ab88666", 45, 131)
                );
        }
    }
}
