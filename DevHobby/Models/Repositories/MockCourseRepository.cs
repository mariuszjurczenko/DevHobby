using DevHobby.Models.Entities;

namespace DevHobby.Models.Repositories;

public class MockCourseRepository : ICourseRepository
{
    private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

    public IEnumerable<Course> AllCourses
        => new List<Course>
        {
            new Course
            {
                CourseId = 1,
                Name = "Angular – Od Zera Do Bohatera",
                Author = "Mariusz Jurczenko",
                Price = 100,
                ImageUrl = "https://dev-hobby.pl/wordpress/wp-content/uploads/2020/09/Angular-Od-Zera-Do-Bohatera.png",
                ImageThumbnailUrl = "https://dev-hobby.pl/wordpress/wp-content/uploads/2020/09/Angular-Od-Zera-Do-Bohatera-300x169.png",
                IsCourseOfTheMonth = false,
                IsRecommended = true,
                Description = new Description
                {
                    DescriptionId = 1,
                    Name= "Wprowadzenie do Angular – Szybki start.",
                    WhatWillYouLearn = new List<WhatWillYouLearn>
                    {
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 1,
                            Content = "Angular CLI"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 2,
                            Content = "Konfiguracja projektu"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 3,
                            Content = "ES5, ES6, TypeScript"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 4,
                            Content = "Dependency Injection"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 5,
                            Content = "Propery binding"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 6,
                            Content = "Event binding"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 7,
                            Content = "Two-way binding"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 8,
                            Content = "Komponent, Moduł"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 9,
                            Content = "Get, Post, Delete, Patch"
                        },

                    },
                    Requirements = new List<Requirement>
                    {
                        new Requirement
                        {
                            RequirementId = 1,
                            Content ="Chęć dobrej zabawy !!!"
                        }
                    },
                    WhoIsThisCourseFor = new List<WhoIsThisCourseFor>
                    {
                        new WhoIsThisCourseFor
                        {
                            WhoIsThisCourseForId = 1,
                            Content = "Każdy kto ma trochę chęci i trochę czasu"
                        }
                    },
                    Content = "Rozpoczęcie nowego projektu opartego o Angular wymaga stworzenia odpowiedniej struktury folderów, skonfigurowania środowiska, zainstalowania TypeScript, definicji typów, stworzenia pierwszego komponentu i wywołania funkcji bootstrap. Zacznijmy budowanie aplikacji od stworzenia potrzebnych komponentów przy pomocy Angular CLI. Dzięki pomocy Angular CLI, nie musimy już powtarzać wielu manualnych czynności co znacznie przyspiesza pracę z Angular.",
                },
                CourseContent = new List<Content>
                {
                    new Content
                    {
                        ContentId = 1,
                        Chapters = new List<Chapter>
                        {
                            new Chapter
                            {
                                ChapterId = 1,
                                Name = "Pierwsza Aplikacja",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 1,
                                        Name = "Lekcja 1",
                                        Duration = "00:14:36"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 2,
                                        Name = "Lekcja 2",
                                        Duration = "00:47:27"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 2,
                                Name = "Druga Aplikacja",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 3,
                                        Name = "Lekcja 1",
                                        Duration = "00:21:25"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 4,
                                        Name = "Lekcja 2",
                                        Duration = "00:17:04"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 5,
                                        Name = "Lekcja 3",
                                        Duration = "00:23:40"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 6,
                                        Name = "Lekcja 4",
                                        Duration = "00:15:11"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 7,
                                        Name = "Lekcja 5",
                                        Duration = "00:14:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 8,
                                        Name = "Lekcja 6",
                                        Duration = "00:24:31"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 9,
                                        Name = "Lekcja 7",
                                        Duration = "00:13:58"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 10,
                                        Name = "Lek8ja 8",
                                        Duration = "00:17:13"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 11,
                                        Name = "Lekcja 9",
                                        Duration = "00:13:09"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 12,
                                        Name = "Lekcja 10",
                                        Duration = "00:22:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 13,
                                        Name = "Lekcja11",
                                        Duration = "00:13:41"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 14,
                                        Name = "Lekcja 12",
                                        Duration = "00:23:05"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 15,
                                        Name = "Lekcja13",
                                        Duration = "00:07:29"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 16,
                                        Name = "Lekcja14",
                                        Duration = "00:10:26"
                                    }
                                },
                            },
                            new Chapter
                            {
                                ChapterId = 3,
                                Name = "Trzecia Aplikacja",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 17,
                                        Name = "Lekcja 1",
                                        Duration = "00:15:28"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 18,
                                        Name = "Lekcja 2",
                                        Duration = "00:12:52"
                                    },
                                     new Lesson
                                    {
                                        LessonId = 19,
                                        Name = "Lekcja 3",
                                        Duration = "00:22:22"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 20,
                                        Name = "Lekcja 4",
                                        Duration = "00:17:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 21,
                                        Name = "Lekcja 5",
                                        Duration = "00:26:43"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 22,
                                        Name = "Lekcja 6",
                                        Duration = "00:20:17"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 23,
                                        Name = "Lekcja 7",
                                        Duration = "00:15:06"
                                    },
                                     new Lesson
                                    {
                                        LessonId = 24,
                                        Name = "Lek8ja 8",
                                        Duration = "00:17:06"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 25,
                                        Name = "Lekcja 9",
                                        Duration = "00:29:34"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 26,
                                        Name = "Lekcja 10",
                                        Duration = "00:14:20"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 27,
                                        Name = "Lekcja11",
                                        Duration = "00:12:03"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 28,
                                        Name = "Lekcja 12",
                                        Duration = "00:12:31"
                                    }
                                },
                            },
                            new Chapter
                            {
                                ChapterId = 4,
                                Name = "Http Promises Observables",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 29,
                                        Name = "Http",
                                        Duration = "00:29:23"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 30,
                                        Name = "Promises",
                                        Duration = "00:49:46"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 31,
                                        Name = "Observables",
                                        Duration = "00:18:36"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 5,
                                Name = "Zakładki - Wykorzystanie Http...",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 32,
                                        Name = "Lekcja 1",
                                        Duration = "00:15:31"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 33,
                                        Name = "Lekcja 2",
                                        Duration = "00:32:06"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 34,
                                        Name = "Lekcja 3",
                                        Duration = "00:30:10"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 35,
                                        Name = "Lekcja 4",
                                        Duration = "00:14:10"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 36,
                                        Name = "Lekcja 5",
                                        Duration = "00:19:32"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 37,
                                        Name = "Lekcja 6",
                                        Duration = "00:21:48"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 6,
                                Name = "Formularz",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 38,
                                        Name = "Lekcja 1",
                                        Duration = "00:23:45"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 39,
                                        Name = "Lekcja 2",
                                        Duration = "00:23:37"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 40,
                                        Name = "Lekcja 3",
                                        Duration = "00:19:16"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 41,
                                        Name = "Lekcja 4",
                                        Duration = "00:14:41"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 7,
                                Name = "Z Całkiem Innej Beczki",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 42,
                                        Name = "Canva",
                                        Duration = "00:16:11"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 43,
                                        Name = "Nozbe",
                                        Duration = "00:18:28"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 44,
                                        Name = "Evernote",
                                        Duration = "00:12:26"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 45,
                                        Name = "Generator Kalendarzy",
                                        Duration = "00:06:58"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 46,
                                        Name = "Smash i WeTransfer",
                                        Duration = "00:09:13"
                                    }
                                }
                            }
                        }
                    }
                },
                Faq = new List<Faq>
                {
                    new Faq
                    {
                        FaqId = 1,
                        Question = "Pytanie 1",
                        Answer = "Odpowiedz na pierwsze czesto zadawane pytanie."
                    },
                    new Faq
                    {
                        FaqId = 2,
                        Question = "Pytanie 2",
                        Answer = "Odpowiedz na drugie czesto zadawane pytanie."
                    },
                    new Faq
                    {
                        FaqId = 3,
                        Question = "Pytanie 3",
                        Answer = "Odpowiedz na trzecie czesto zadawane pytanie."
                    },
                    new Faq
                    {
                        FaqId = 4,
                        Question = "Pytanie 4",
                        Answer = "Odpowiedz na czwarte czesto zadawane pytanie."
                    },
                    new Faq
                    {
                        FaqId = 5,
                        Question = "Pytanie 5",
                        Answer = "Odpowiedz na piąte czesto zadawane pytanie."
                    }
                },
                Announcements = new List<Announcement>
                {
                    new Announcement
                    {
                        AnnouncementId = 1,
                        Content = "Kod źródłowy dostępny na githubie : https://github.com/mariuszjurczenko/Angular2_AppFirst"
                    },
                    new Announcement
                    {
                        AnnouncementId = 2,
                        Content = "Kod źródłowy dostępny na githubie : https://github.com/mariuszjurczenko/Angular2_Converter"
                    },
                    new Announcement
                    {
                        AnnouncementId = 3,
                        Content = "Kod źródłowy dostępny na githubie : https://github.com/mariuszjurczenko/Angular2-formularz"
                    },
                    new Announcement
                    {
                        AnnouncementId = 4,
                        Content = "Kod źródłowy dostępny na githubie : https://github.com/mariuszjurczenko/Angular2-bookmarks2"
                    },
                    new Announcement
                    {
                        AnnouncementId = 5,
                        Content = "Kod źródłowy dostępny na githubie : https://github.com/mariuszjurczenko/Angular2-Http-odc29"
                    },
                    new Announcement
                    {
                        AnnouncementId = 6,
                        Content = "Kod źródłowy dostępny na githubie : https://github.com/mariuszjurczenko/Angular2-Http-odc30"
                    },
                },
                Opinions = new List<Opinion>
                {
                    new Opinion
                    {
                        OpinionId = 1,
                        Content = "Bardzo ważny i przydatny kurs dla każdego. Kurs zawiera wiele cennych informacji na temat angulara. Polecam. :)",
                        NumberOfStars = 5
                    }
                },
                Category = _categoryRepository.AllCategories.ToList()[6]
            },
            new Course
            {
                CourseId = 2,
                Name = "Seria Programista C# – część 1 – Podstawy Programowania",
                Author = "Mariusz Jurczenko",
                Price = 100,
                ImageUrl = "https://dev-hobby.pl/wordpress/wp-content/uploads/2020/09/Programista-C-Part1.png",
                ImageThumbnailUrl = "https://dev-hobby.pl/wordpress/wp-content/uploads/2020/09/Programista-C-Part1-300x169.png",
                IsCourseOfTheMonth = false,
                IsRecommended = true,
                Description = new Description
                {
                    DescriptionId = 2,
                    Name= "C# Podstawy programowania",
                    WhatWillYouLearn = new List<WhatWillYouLearn>
                    {
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 10,
                            Content = "W krótkim czasie poznasz zupełnie od podstaw kompletny proces budowania aplikacji C#"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 11,
                            Content = "Zaczniesz programować pierwsze aplikacje"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 12,
                            Content = "Bedziesz tworzyć klasy i obiekty w swojm kodzie"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 13,
                            Content = "Zrozumiesz Delegaty i Zdarzenia"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 14,
                            Content = "Obsługi wyjątków"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 15,
                            Content = "Unikania często popełnianych błędów"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 16,
                            Content = "Wiele przydatnych wskazówek i dobrych praktyk"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 17,
                            Content = "Będziesz się dobrze bawić pisząc kod C#"
                        }
                    },
                    Requirements = new List<Requirement>
                    {
                        new Requirement
                        {
                            RequirementId = 2,
                            Content = "Chęć nauki programowania i dobrej zabawy !!!"
                        }
                    },
                    WhoIsThisCourseFor = new List<WhoIsThisCourseFor>
                    {
                        new WhoIsThisCourseFor
                        {
                            WhoIsThisCourseForId = 2,
                            Content = "Początkujący programiści C#"
                        },
                        new WhoIsThisCourseFor
                        {
                            WhoIsThisCourseForId = 3,
                            Content = "Chcesz w krótkim czasie poznać zupełnie od podstaw kompletny proces budowania aplikacji z C#?"
                        },
                        new WhoIsThisCourseFor
                        {
                            WhoIsThisCourseForId = 4,
                            Content = "Chcesz opanować podstawy języka C#, zacznij programować pierwsze aplikacje jeszcze dziś!"
                        },
                        new WhoIsThisCourseFor
                        {
                            WhoIsThisCourseForId = 5,
                            Content = "Chcesz tworzyć klasy i obiekty w C#?"
                        }
                    },
                    Content = "Szkolenie powstało z myślą o osobach początkujących, które chciałyby nauczyć się podstaw programowania w języku C# na praktycznych i prostych do zrozumienia przykładach. C# jak każdy język programowania ma mocne i słabe strony. Niektóre  języki są wydajne, lecz podatne na błędy lub trudne w stosowaniu, podczas gdy inne są prostsze, lecz mogą mieć ograniczoną funkcjonalność lub słabszą wydajność. C# jest językiem zaprojektowanym tak, aby stanowił optymalne połączenie prostoty, efektywności oraz użyteczności. W trakcie kursu będziesz budował proste aplikacje, co pozwoli Ci poznać dobrze różne obszary języka. Przyswoisz sobie wiele przydatnych wskazówek i dobrych praktyk, które pozwolą Ci zachować czytelność kodu i uniknąć najczęściej popełnianych błędów. Tworzenie klas to istota programowania.  To właśnie dlatego poświęciłem im cały rozdział. Dowiesz się z  niego między innymi jaką funkcję pełnią klasy w języku C#, jak je tworzyć oraz czym różnią się one od zmiennych. Poruszymy również bardzo  ważny temat hermetyzacji, modyfikatorów dostępu oraz budowy konstruktorów.",
                },
                CourseContent = new List<Content>
                {
                    new Content
                    {
                        ContentId = 2,
                        Chapters = new List<Chapter>
                        {
                            new Chapter
                            {
                                ChapterId = 8,
                                Name = "Wstęp",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 47,
                                        Name = "Wprowadzenie Do Kursu",
                                        Duration = "00:05:12"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 48,
                                        Name = ".NET, CLR, FCL",
                                        Duration = "00:10:32"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 49,
                                        Name = "Pierwszy Program",
                                        Duration = "00:20:13"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 50,
                                        Name = "Pierwszy Program W Visual Studio",
                                        Duration = "00:26:37"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 51,
                                        Name = "IDE",
                                        Duration = "00:22:38"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 52,
                                        Name = "Zaczynamy Kodowanie :)",
                                        Duration = "00:38:49"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 53,
                                        Name = "Quiz",
                                        Duration = "3 pytania"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 9,
                                Name = "Klasy I Obiekty",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 54,
                                        Name = "Nasza Pierwsza Klasa",
                                        Duration = "00:26:04"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 55,
                                        Name = "Tworzenie Obiektów",
                                        Duration = "00:38:43"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 56,
                                        Name = "Konstruktor",
                                        Duration = "00:25:34"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 57,
                                        Name = "Klasa A Zmienna",
                                        Duration = "00:23:04"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 58,
                                        Name = "Programowania Obiektowe",
                                        Duration = "00:24:54"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 59,
                                        Name = "Programowania Obiektowe cz.2",
                                        Duration = "00:22:53"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 60,
                                        Name = "Hermetyzacja I Modyfikatory Dostępu",
                                        Duration = "00:20:09"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 61,
                                        Name = "STATIC",
                                        Duration = "00:19:35"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 62,
                                        Name = "Quiz",
                                        Duration = "3 pytania"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 10,
                                Name = "Typy I Złożenia",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 63,
                                        Name = "Typy Referencyjne",
                                        Duration = "00:17:45"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 64,
                                        Name = "Typy Wartościowe",
                                        Duration = "00:19:31"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 65,
                                        Name = "Parametry Metody",
                                        Duration = "00:37:12"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 66,
                                        Name = "Struktury I Wyliczenia",
                                        Duration = "00:23:58"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 67,
                                        Name = "Immutable",
                                        Duration = "00:27:28"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 68,
                                        Name = "Tablice",
                                        Duration = "00:30:23"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 69,
                                        Name = "Złożenia",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 70,
                                        Name = "Unit Tests",
                                        Duration = "00:41:36"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 71,
                                        Name = "Quiz",
                                        Duration = "4 pytania"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 11,
                                Name = "Członkowie Klasy",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 72,
                                        Name = "Członkowie Klasy",
                                        Duration = "00:35:44"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 73,
                                        Name = "Pola I Właściwości",
                                        Duration = "00:24:43"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 74,
                                        Name = "Delegaty",
                                        Duration = "00:19:39"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 75,
                                        Name = "Zdarzenia",
                                        Duration = "00:21:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 76,
                                        Name = "Quiz",
                                        Duration = "4 pytania"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 12,
                                Name = "Kontrola Przepływu Aplikacji",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 77,
                                        Name = "Rozgałęzienia Wykonania Kodu",
                                        Duration = "00:21:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 78,
                                        Name = "Przelączanie",
                                        Duration = "00:13:08"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 79,
                                        Name = "Pętle",
                                        Duration = "00:24:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 80,
                                        Name = "Instrukcje Skoku",
                                        Duration = "00:17:59"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 81,
                                        Name = "Throw",
                                        Duration = "00:14:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 82,
                                        Name = "Try Catch",
                                        Duration = "00:22:47"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 83,
                                        Name = "PFinally",
                                        Duration = "00:17:14"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 84,
                                        Name = "Quiz",
                                        Duration = "4 pytania"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 85,
                                        Name = "Podsumowanie Kursu",
                                        Duration = "00:01:58"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 86,
                                        Name = "Dodatkowe materiały",
                                        Duration = ""
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 13,
                                Name = "Z Całkiem Innej Beczki",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 87,
                                        Name = "Canva",
                                        Duration = "00:16:11"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 88,
                                        Name = "Nozbe",
                                        Duration = "00:18:28"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 89,
                                        Name = "Evernote",
                                        Duration = "00:12:26"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 90,
                                        Name = "Generator Kalendarzy",
                                        Duration = "00:06:58"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 91,
                                        Name = "Smash i WeTransfer",
                                        Duration = "00:09:13"
                                    }
                                }
                            }
                        }
                    }
                },
                Faq = new List<Faq>
                {
                    new Faq
                    {
                        FaqId = 6,
                        Question = "Jaka jest różnica pomiędzy klasą a obiektem?",
                        Answer = "Klasa jest definicją obiektu, a obiekt jest instancją klasy."
                    },
                    new Faq
                    {
                        FaqId = 7,
                        Question = "Czy w języku C# można utworzyć metodę, która może przyjmować zmienną liczbę parametrów?",
                        Answer = "Tak, należy użyć słowa kluczowego params. Metoda taka może przyjąć zmienną liczbę parametrów."
                    },
                    new Faq
                    {
                        FaqId = 8,
                        Question = "Co to są typy referencyjne?",
                        Answer = "Typy referencyjne nie przechowują rzeczywistych wartości a jedynie odniesienia(referencje) do zmiennych."
                    }
                },
                Announcements = new List<Announcement>
                {
                    new Announcement
                    {
                        AnnouncementId = 7,
                        Content = "Kod źródłowy dostępny na githubie : https://github.com/mariuszjurczenko/CSarpKurs"
                    }
                },
                Opinions = new List<Opinion>
                {
                    new Opinion
                    {
                        OpinionId = 2,
                        Content = "Bardzo dobrze przedstawione podstawy języka C#. Prowadzący przedstawia poszczególne elementy składni języka w przestępny sposób i na konkretnych przykładach. Lekcje bardzo dobrze przemyślane dzięki czemu możemy przećwiczyć poruszane w nich zagadnienia krok po kroku.",
                        NumberOfStars = 5
                    },
                    new Opinion
                    {
                        OpinionId = 3,
                        Content = "Dobry kurs podstaw języka C#. Trochę teorii i przykładów. Idealny na powtórzenie sobie materiału z języka C#. Dowiedziałem się kilku nowych rzeczy na które wcześniej nie zwróciłem uwagi takich jak przydatne skróty klawiszowe do szybszego pisania kodu, umieszczenie projektu na githubie, testy jednostkowe, delegaty i zdarzenia. Polecam.",
                        NumberOfStars = 5
                    },
                    new Opinion
                    {
                        OpinionId = 4,
                        Content = "Świetne wprowadzenie do programowania w C#. Szczególnie spodobało mi się, że kurs jest bardzo dobrze przemyślany i zaplanowany. Wszystko jest wytłumaczone bardzo klarownie, przeszedłem przez ten kurs z przyjemnością i zaczynam cześć drugą ;)",
                        NumberOfStars = 5
                    },
                },
                Category = _categoryRepository.AllCategories.ToList()[0]
            },
            new Course
            {
                CourseId = 3,
                Name = "CMS Shop Paypal – Praktyczny projekt",
                Author = "Mariusz Jurczenko",
                Price = 100,
                ImageUrl = "https://dev-hobby.pl/wordpress/wp-content/uploads/2020/09/CMs-shop-paypal-870x440.png",
                ImageThumbnailUrl = "https://dev-hobby.pl/wordpress/wp-content/uploads/2020/09/CMs-shop-paypal-300x169.png",
                IsCourseOfTheMonth = false,
                IsRecommended = true,
                Description = new Description
                {
                    DescriptionId = 3,
                    Name= "CMSShop Praktyczny projekt w Asp.Net Mvc zintegrowany z systemem płatności Paypal.",
                    WhatWillYouLearn = new List<WhatWillYouLearn>
                    {
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 18,
                            Content = "Stworzysz praktyczny projekt Cms i sklep w AspNet MVC zintegrowany z systemem płatności Paypal"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 19,
                            Content = "W krótkim czasie poznasz zupełnie od podstaw kompletny proces budowania aplikacji ASP_NET MVC"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 20,
                            Content = "W praktyce wykorzystasz swoją znajomość języka C#"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 21,
                            Content = "Zdobędziesz umiejętności, które zapewnią Ci szansę na wspaniałą karierę zawodową"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 22,
                            Content = "Opanujesz liczne pojęcia, koncepcje oraz techniki, których znajomość jest niezbędna podczas tworzenia nowoczesnych aplikacji"
                        }
                    },
                    Requirements = new List<Requirement>
                    {
                        new Requirement
                        {
                            RequirementId = 3,
                            Content = "Podstawowa znajomość C#"
                        },
                        new Requirement
                        {
                            RequirementId = 4,
                            Content = "Podstawowa znajomość AspNet Mvc"
                        },
                    },
                    WhoIsThisCourseFor = new List<WhoIsThisCourseFor>
                    {
                        new WhoIsThisCourseFor
                        {
                            WhoIsThisCourseForId = 6,
                            Content = "Początkujący programiści AspNet Mvc"
                        },
                        new WhoIsThisCourseFor
                        {
                            WhoIsThisCourseForId = 7,
                            Content = "CChcesz w krótkim czasie poznać zupełnie od podstaw kompletny proces budowania aplikacji z ASP_NET?"
                        },
                        new WhoIsThisCourseFor
                        {
                            WhoIsThisCourseForId = 8,
                            Content = "Chcesz w praktyce wykorzystać swoją znajomość języka C# i zdobyć umiejętności, które zapewnią Ci szansę na wspaniałą karierę zawodową?"
                        },
                        new WhoIsThisCourseFor
                        {
                            WhoIsThisCourseForId = 9,
                            Content = "Chcesz opanować liczne pojęcia, koncepcje oraz techniki, których znajomość jest niezbędna podczas tworzenia nowoczesnych aplikacji?"
                        }
                    },
                    Content = "Projekt ten łączy w sobie funkcjonalność CMSa – systemu do zarządzania  treścią oraz funkcjonalność sklepu internetowego. Wszystko to jest  zrealizowane w jednym projekcie. Zawartość kursu mogła by być  wykorzystana w kilku osobnych kursach takich jak: asp.net mvc,  bootstrap, adminLte, cms, sklep. Całość stanowi jeden duży praktyczny  projekt, który musi być realizowany zgodnie z kolejnością nagranych  odcinków i który został podzielony na mniejsze moduły funkcjonalne.",
                },
                CourseContent = new List<Content>
                {
                    new Content
                    {
                        ContentId = 3,
                        Chapters = new List<Chapter>
                        {
                            new Chapter
                            {
                                ChapterId = 14,
                                Name = "Rozpoczęcie Projektu Konfiguracja Administracja CMS",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 92,
                                        Name = "Lekcja 1",
                                        Duration = "00:11:18"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 93,
                                        Name = "Lekcja 2",
                                        Duration = "00:09:04"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 94,
                                        Name = "Lekcja 3",
                                        Duration = "00:17:57"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 95,
                                        Name = "Lekcja 4",
                                        Duration = "00:15:11"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 96,
                                        Name = "Lekcja 5",
                                        Duration = "00:14:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 97,
                                        Name = "Lekcja 6",
                                        Duration = "00:24:31"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 98,
                                        Name = "Lekcja 7",
                                        Duration = "00:13:58"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 99,
                                        Name = "Lek8ja 8",
                                        Duration = "00:17:13"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 100,
                                        Name = "Lekcja 9",
                                        Duration = "00:13:09"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 101,
                                        Name = "Lekcja 10",
                                        Duration = "00:22:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 102,
                                        Name = "Lekcja 11",
                                        Duration = "00:13:41"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 103,
                                        Name = "Lekcja 12",
                                        Duration = "00:23:05"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 104,
                                        Name = "Lekcja 13",
                                        Duration = "00:07:29"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 105,
                                        Name = "Lekcja 14",
                                        Duration = "00:10:26"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 106,
                                        Name = "Lekcja 15",
                                        Duration = "00:22:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 107,
                                        Name = "Lekcja 16",
                                        Duration = "00:13:41"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 108,
                                        Name = "Lekcja 17",
                                        Duration = "00:23:05"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 109,
                                        Name = "Lekcja 18",
                                        Duration = "00:07:29"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 110,
                                        Name = "Lekcja 19",
                                        Duration = "00:10:26"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 15,
                                Name = "Administracja Sklep",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 111,
                                        Name = "Lekcja 1",
                                        Duration = "00:11:18"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 112,
                                        Name = "Lekcja 2",
                                        Duration = "00:09:04"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 113,
                                        Name = "Lekcja 3",
                                        Duration = "00:17:57"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 114,
                                        Name = "Lekcja 4",
                                        Duration = "00:15:11"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 115,
                                        Name = "Lekcja 5",
                                        Duration = "00:14:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 116,
                                        Name = "Lekcja 6",
                                        Duration = "00:24:31"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 117,
                                        Name = "Lekcja 7",
                                        Duration = "00:13:58"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 118,
                                        Name = "Lek8ja 8",
                                        Duration = "00:17:13"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 119,
                                        Name = "Lekcja 9",
                                        Duration = "00:13:09"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 120,
                                        Name = "Lekcja 10",
                                        Duration = "00:22:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 121,
                                        Name = "Lekcja 11",
                                        Duration = "00:13:41"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 122,
                                        Name = "Lekcja 12",
                                        Duration = "00:23:05"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 123,
                                        Name = "Lekcja 13",
                                        Duration = "00:07:29"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 124,
                                        Name = "Lekcja 14",
                                        Duration = "00:10:26"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 125,
                                        Name = "Lekcja 15",
                                        Duration = "00:22:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 126,
                                        Name = "Lekcja 16",
                                        Duration = "00:13:41"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 127,
                                        Name = "Lekcja 17",
                                        Duration = "00:23:05"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 128,
                                        Name = "Lekcja 18",
                                        Duration = "00:07:29"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 129,
                                        Name = "Lekcja 19",
                                        Duration = "00:10:26"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 130,
                                        Name = "Lekcja 20",
                                        Duration = "00:13:41"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 131,
                                        Name = "Lekcja 21",
                                        Duration = "00:23:05"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 132,
                                        Name = "Lekcja 22",
                                        Duration = "00:07:29"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 133,
                                        Name = "Lekcja 23",
                                        Duration = "00:10:26"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 134,
                                        Name = "Lekcja 24",
                                        Duration = "00:23:05"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 135,
                                        Name = "Lekcja 25",
                                        Duration = "00:07:29"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 136,
                                        Name = "Lekcja 26",
                                        Duration = "00:10:26"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 137,
                                        Name = "Lekcja 27",
                                        Duration = "00:23:05"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 138,
                                        Name = "Lekcja 28",
                                        Duration = "00:07:29"
                                    },
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 16,
                                Name = "Front CMS Sklep",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 139,
                                        Name = "Lekcja 1",
                                        Duration = "00:11:18"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 140,
                                        Name = "Lekcja 2",
                                        Duration = "00:09:04"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 141,
                                        Name = "Lekcja 3",
                                        Duration = "00:17:57"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 142,
                                        Name = "Lekcja 4",
                                        Duration = "00:15:11"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 143,
                                        Name = "Lekcja 5",
                                        Duration = "00:14:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 144,
                                        Name = "Lekcja 6",
                                        Duration = "00:24:31"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 145,
                                        Name = "Lekcja 7",
                                        Duration = "00:13:58"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 17,
                                Name = "Sklep Koszyk",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 146,
                                        Name = "Lekcja 1",
                                        Duration = "00:11:18"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 147,
                                        Name = "Lekcja 2",
                                        Duration = "00:09:04"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 148,
                                        Name = "Lekcja 3",
                                        Duration = "00:17:57"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 149,
                                        Name = "Lekcja 4",
                                        Duration = "00:15:11"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 150,
                                        Name = "Lekcja 5",
                                        Duration = "00:14:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 151,
                                        Name = "Lekcja 6",
                                        Duration = "00:24:31"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 152,
                                        Name = "Lekcja 7",
                                        Duration = "00:13:58"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 153,
                                        Name = "Lekcja 8",
                                        Duration = "00:13:58"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 18,
                                Name = "Rejestracja Logowanie Role",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 154,
                                        Name = "Lekcja 1",
                                        Duration = "00:11:18"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 155,
                                        Name = "Lekcja 2",
                                        Duration = "00:09:04"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 156,
                                        Name = "Lekcja 3",
                                        Duration = "00:17:57"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 157,
                                        Name = "Lekcja 4",
                                        Duration = "00:15:11"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 158,
                                        Name = "Lekcja 5",
                                        Duration = "00:14:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 159,
                                        Name = "Lekcja 6",
                                        Duration = "00:24:31"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 160,
                                        Name = "Lekcja 7",
                                        Duration = "00:13:58"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 161,
                                        Name = "Lekcja 8",
                                        Duration = "00:13:58"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 162,
                                        Name = "Lekcja 9",
                                        Duration = "00:13:58"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 19,
                                Name = "Rejestracja Logowanie Role",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 163,
                                        Name = "Lekcja 1",
                                        Duration = "00:11:18"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 164,
                                        Name = "Lekcja 2",
                                        Duration = "00:09:04"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 165,
                                        Name = "Lekcja 3",
                                        Duration = "00:17:57"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 166,
                                        Name = "Lekcja 4",
                                        Duration = "00:15:11"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 167,
                                        Name = "Lekcja 5",
                                        Duration = "00:14:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 168,
                                        Name = "Lekcja 6",
                                        Duration = "00:24:31"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 169,
                                        Name = "Lekcja 7",
                                        Duration = "00:13:58"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 170,
                                        Name = "Lekcja 8",
                                        Duration = "00:13:58"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 171,
                                        Name = "Lekcja 9",
                                        Duration = "00:13:58"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 172,
                                        Name = "Lekcja 10",
                                        Duration = "00:13:58"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 173,
                                        Name = "Lekcja 11",
                                        Duration = "00:13:58"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 174,
                                        Name = "Lekcja 12",
                                        Duration = "00:13:58"
                                    },
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 20,
                                Name = "Z Całkiem Innej Beczki",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 175,
                                        Name = "Canva",
                                        Duration = "00:16:11"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 176,
                                        Name = "Nozbe",
                                        Duration = "00:18:28"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 177,
                                        Name = "Evernote",
                                        Duration = "00:12:26"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 178,
                                        Name = "Generator Kalendarzy",
                                        Duration = "00:06:58"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 179,
                                        Name = "Smash i WeTransfer",
                                        Duration = "00:09:13"
                                    }
                                }
                            }
                        }
                    }
                },
                Faq = new List<Faq>
                {
                    new Faq
                    {
                        FaqId = 9,
                        Question = "Pytanie 1",
                        Answer = "Odpowiedz na pierwsze często zadawane pytanie"
                    }
                },
                Announcements = new List<Announcement>
                {
                    new Announcement
                    {
                        AnnouncementId = 8,
                        Content = "Kod źródłowy dostępny na githubie : https://github.com/mariuszjurczenko/CmsShop"
                    }
                },
                Opinions = new List<Opinion>
                {
                    new Opinion
                    {
                        OpinionId = 5,
                        Content = "Przykładowa opinia",
                        NumberOfStars = 5
                    }
                },
                Category = _categoryRepository.AllCategories.ToList()[2]
            },
            new Course
            {
                CourseId = 4,
                Name = "Seria Programista C# – część 2 – Podstawy Programowanie Obiektowego",
                Author = "Mariusz Jurczenko",
                Price = 100,
                ImageUrl = "https://dev-hobby.pl/wordpress/wp-content/uploads/2020/09/Programista-C-Part2.png",
                ImageThumbnailUrl = "https://dev-hobby.pl/wordpress/wp-content/uploads/2020/09/Programista-C-Part2-300x169.png",
                IsCourseOfTheMonth = false,
                IsRecommended = true,
                Description = new Description
                {
                    DescriptionId = 4,
                    Name= "Podstawy Programowanie obiektowego w języku C#",
                    WhatWillYouLearn = new List<WhatWillYouLearn>
                    {
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 23,
                            Content = "Bedziesz tworzyć klasy i obiekty w swojm kodzie"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 24,
                            Content = "Będziesz analizował i identyfikował klas z wymagań biznesowych"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 25,
                            Content = "Bedziesz potrafił rozdzielać obowiązki klasy"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 26,
                            Content = "Nauczysz się rozpoznawać relacje między klasami "
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 27,
                            Content = "Zrozumiesz ideę ponownego użycia"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 28,
                            Content = "Nauczysz się budować komponenty"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 29,
                            Content = "Nauczysz się korzystać z interfejsów"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 30,
                            Content = "Opanujesz Ideą polimorfizmu"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 31,
                            Content = "W krótkim czasie poznasz zupełnie od podstaw kompletny proces budowania aplikacji C#"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 32,
                            Content = "Unikania często popełnianych błędów#"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 33,
                            Content = "Wiele przydatnych wskazówek i dobrych praktyk"
                        }
                    },
                    Requirements = new List<Requirement>
                    {
                        new Requirement
                        {
                            RequirementId = 5,
                            Content = "Chęć nauki programowania i dobrej zabawy !!!"
                        },
                        new Requirement
                        {
                            RequirementId = 6,
                            Content = "C# Podstawy programowania"
                        },
                    },
                    WhoIsThisCourseFor = new List<WhoIsThisCourseFor>
                    {
                        new WhoIsThisCourseFor
                        {
                            WhoIsThisCourseForId = 10,
                            Content = "Programiści C#"
                        },
                        new WhoIsThisCourseFor
                        {
                            WhoIsThisCourseForId = 11,
                            Content = "Chcesz tworzyć klasy i obiekty w C#?"
                        },
                        new WhoIsThisCourseFor
                        {
                            WhoIsThisCourseForId = 12,
                            Content = "Chcesz analizować i identyfikować klas z wymagań biznesowych?"
                        },
                        new WhoIsThisCourseFor
                        {
                            WhoIsThisCourseForId = 13,
                            Content = "Chcesz potrafić rozdzielać obowiązki klasy?"
                        },
                        new WhoIsThisCourseFor
                        {
                            WhoIsThisCourseForId = 14,
                            Content = "Chcesz nauczyć się rozpoznawać relacje między klasami?"
                        },
                        new WhoIsThisCourseFor
                        {
                            WhoIsThisCourseForId = 15,
                            Content = "Chcesz zrozumieć ideę ponownego użycia?"
                        },
                        new WhoIsThisCourseFor
                        {
                            WhoIsThisCourseForId = 16,
                            Content = "Chcesz nauczyć się budować komponenty?"
                        },
                        new WhoIsThisCourseFor
                        {
                            WhoIsThisCourseForId = 17,
                            Content = "Chcesz nauczyć się korzystać z interfejsów?"
                        },
                        new WhoIsThisCourseFor
                        {
                            WhoIsThisCourseForId = 18,
                            Content = "Chcesz opanować Ideą polimorfizmu?"
                        },
                        new WhoIsThisCourseFor
                        {
                            WhoIsThisCourseForId = 19,
                            Content = "Chcesz w krótkim czasie poznać zupełnie od podstaw kompletny proces budowania aplikacji z C#?"
                        },
                    },
                    Content = "Tematem tego kursu będzie programowanie w języku C #, a dokładnie wszystko co powinieneś wiedzieć o programowaniu obiektowym. Po podaniu specyfikacji nowej funkcji lub nowej aplikacji zacznij od zidentyfikowania klas z wymagań lub specyfikacji. Programowanie obiektowe reprezentuje encje i koncepcje aplikacji jako zbioru klas. Następnym krokiem jest przeanalizowanie zidentyfikowanych klas i podział obowiązków w zależności od potrzeb. Chodzi o to, że aplikacja powinna zostać rozłożona na części z minimalnym nakładaniem się funkcji. Jeśli każda klasa ma jeden cel, łatwiej jest pisać, testować, a później znajdować tę klasę, gdy trzeba ją zaktualizować lub rozszerzyć. To sprawia, że kod jest łatwiejszy do modyfikacji i dostosowania do nowych wymagań i przyszłych wymagań. Następnym krokiem jest przyjrzenie się związkom. Relacje między klasami definiują sposób, w jaki obiekty utworzone z tych klas mogą współpracować w celu wykonywania operacji aplikacji. Ostatnim krokiem jest wykorzystanie ponownego użycia. Siła programowania obiektowego leży w obietnicy ponownego użycia. Poprzez wyodrębnienie podobieństwa między zestawami klas do oddzielnej klasy, masz więcej kodu wielokrotnego użytku. Rozbudowane ponowne wykorzystanie istniejących, sprawdzonych klas nie tylko skraca czas opracowywania, ale także prowadzi do bardziej niezawodnych aplikacji. Przykładowa aplikacja została ponownie wykorzystana poprzez klasę bazową z wykorzystaniem dziedziczenia. Następnie zademonstrujemy ponowne użycie poprzez bibliotekę komponentów klas ogólnych. I wreszcie, zobaczymy ponowne użycie interfejsów. Interfejsy zapewniają czysty sposób interakcji aplikacji z innymi klasami, komponentami, aplikacjami lub systemami.",
                },
                CourseContent = new List<Content>
                {
                    new Content
                    {
                        ContentId = 4,
                        Chapters = new List<Chapter>
                        {
                            new Chapter
                            {
                                ChapterId = 21,
                                Name = "Wprowadzenie",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 180,
                                        Name = "Wprowadzenie",
                                        Duration = "00:05:12"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 181,
                                        Name = "Porównanie Obiek A Klasa",
                                        Duration = "00:10:32"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 182,
                                        Name = "Co To Jest Programowanie Obiektowe",
                                        Duration = "00:20:13"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 183,
                                        Name = "Konspekt Kursu",
                                        Duration = "00:26:37"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 184,
                                        Name = "Quiz",
                                        Duration = "3 pytania"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 22,
                                Name = "Identyfikacja Klas Z Wymagań Biznesowych",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 185,
                                        Name = "Wprowadzenie",
                                        Duration = "00:26:04"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 186,
                                        Name = "Przeanalizuj Problem Biznesowy",
                                        Duration = "00:38:43"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 187,
                                        Name = "Rozpoczynamy Analizę Od Rzeczowników",
                                        Duration = "00:25:34"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 188,
                                        Name = "Przechodzimy Do Zdefiniowania Odpowiednich Członków",
                                        Duration = "00:23:04"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 189,
                                        Name = "Określenie Naszych Celów – Abstrakcja",
                                        Duration = "00:24:54"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 190,
                                        Name = "Enkapsulacja – Ukrywanie Danych",
                                        Duration = "00:22:53"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 191,
                                        Name = "Podsumowanie",
                                        Duration = "00:20:09"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 192,
                                        Name = "Quiz",
                                        Duration = "3 pytania"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 23,
                                Name = "Budowanie Klasy",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 193,
                                        Name = "Wprowadzenie",
                                        Duration = "00:17:45"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 194,
                                        Name = "Struktura Aplikacji",
                                        Duration = "00:19:31"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 195,
                                        Name = "Utworzenie Warstwy Logiki Biznesowej",
                                        Duration = "00:37:12"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 196,
                                        Name = "Definiowanie Właściwości",
                                        Duration = "00:23:58"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 197,
                                        Name = "Dodajemy Projekt Testów Jednostkowych",
                                        Duration = "00:27:28"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 198,
                                        Name = "Tworzenie Obiektów",
                                        Duration = "00:30:23"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 199,
                                        Name = "Podsumowanie",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 200,
                                        Name = "Quiz",
                                        Duration = "3 pytania"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 24,
                                Name = "Budowanie Klasy - Metody",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 201,
                                        Name = "Wprowadzenie",
                                        Duration = "00:35:44"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 202,
                                        Name = "Metody Klasy",
                                        Duration = "00:24:43"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 203,
                                        Name = "Kilka Dodatkowych Pojęć",
                                        Duration = "00:19:39"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 204,
                                        Name = "Konstruktory",
                                        Duration = "00:21:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 205,
                                        Name = "Dodanie Pozostałych Klas",
                                        Duration = "00:21:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 206,
                                        Name = "Podsumowanie",
                                        Duration = "00:21:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 207,
                                        Name = "Quiz",
                                        Duration = "3 pytania"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 25,
                                Name = "Rozdzielanie Obowiązków",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 208,
                                        Name = "Wprowadzenie",
                                        Duration = "00:21:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 209,
                                        Name = "Diagram Klas",
                                        Duration = "00:13:08"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 210,
                                        Name = "Klasa Adresów",
                                        Duration = "00:24:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 211,
                                        Name = "Budowanie Repozytorium Klienta",
                                        Duration = "00:17:59"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 212,
                                        Name = "Repozytorium Produktu I Zamówienia",
                                        Duration = "00:14:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 213,
                                        Name = "Podsumowanie",
                                        Duration = "00:22:47"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 214,
                                        Name = "Quiz",
                                        Duration = "4 pytania"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 26,
                                Name = "Nawiązywanie Relacji",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 215,
                                        Name = "Wprowadzenie",
                                        Duration = "00:21:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 216,
                                        Name = "Definiowanie Relacji",
                                        Duration = "00:13:08"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 217,
                                        Name = "Typy Relacji",
                                        Duration = "00:24:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 218,
                                        Name = "Współpraca Obiektów",
                                        Duration = "00:17:59"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 219,
                                        Name = "Relacja Kompozycji",
                                        Duration = "00:14:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 220,
                                        Name = "Kompozycja: Referencje",
                                        Duration = "00:22:47"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 221,
                                        Name = "Wypełnianie Obiektów",
                                        Duration = "00:21:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 222,
                                        Name = "Kompozycja: Identyfikatory",
                                        Duration = "00:13:08"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 223,
                                        Name = "Budowanie Klas O Jednym Przeznaczeniu",
                                        Duration = "00:24:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 224,
                                        Name = "Dziedziczenie",
                                        Duration = "00:17:59"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 225,
                                        Name = "Podsumowanie",
                                        Duration = "00:14:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 226,
                                        Name = "Quiz",
                                        Duration = "4 pytania"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 27,
                                Name = "Wykorzystanie Ponownego Użycia",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 227,
                                        Name = "Wprowadzenie",
                                        Duration = "00:21:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 228,
                                        Name = "Techniki Dla Ponownego Wykorzystania",
                                        Duration = "00:13:08"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 229,
                                        Name = "Klasa Object",
                                        Duration = "00:24:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 230,
                                        Name = "Nadpisywanie Funkcjonalności Klasy Podstawowej",
                                        Duration = "00:17:59"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 231,
                                        Name = "Wielopostaciowość – Polimorfizm",
                                        Duration = "00:14:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 232,
                                        Name = "Budowanie Klasy Bazowej",
                                        Duration = "00:22:47"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 233,
                                        Name = "Dziedziczenie Z Klasy Bazowej",
                                        Duration = "00:21:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 234,
                                        Name = "Kod Zapisu",
                                        Duration = "00:13:08"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 235,
                                        Name = "Podsumowanie",
                                        Duration = "00:14:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 236,
                                        Name = "Quiz",
                                        Duration = "4 pytania"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 28,
                                Name = "Budowanie Komponentu Wielokrotnego Użytku",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 237,
                                        Name = "Wprowadzenie",
                                        Duration = "00:21:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 238,
                                        Name = "Budowanie Komponentu Wielokrotnego Użytku",
                                        Duration = "00:13:08"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 239,
                                        Name = "Testowanie Komponentu",
                                        Duration = "00:24:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 240,
                                        Name = "Korzystanie Z Komponentu",
                                        Duration = "00:17:59"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 241,
                                        Name = "Klasy Statyczne",
                                        Duration = "00:14:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 242,
                                        Name = "Metody Rozszerzeń",
                                        Duration = "00:22:47"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 243,
                                        Name = "Metoda Statyczna A Metoda Rozszerzenia",
                                        Duration = "00:21:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 244,
                                        Name = "Podsumowanie",
                                        Duration = "00:13:08"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 245,
                                        Name = "Quiz",
                                        Duration = "3 pytania"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 29,
                                Name = "Wprowadzenie Do Interfejsów",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 246,
                                        Name = "Wprowadzenie",
                                        Duration = "00:21:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 247,
                                        Name = "Interfejsy .NET",
                                        Duration = "00:13:08"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 248,
                                        Name = "Logowanie",
                                        Duration = "00:24:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 249,
                                        Name = "Definiowanie Interfejsu",
                                        Duration = "00:17:59"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 250,
                                        Name = "Implementacja Interfejsu",
                                        Duration = "00:14:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 251,
                                        Name = "Polimorfizm Oparty Na Interfejsie",
                                        Duration = "00:22:47"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 252,
                                        Name = "Testy",
                                        Duration = "00:21:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 253,
                                        Name = "Podsumowanie",
                                        Duration = "00:13:08"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 254,
                                        Name = "Quiz",
                                        Duration = "3 pytania"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 255,
                                        Name = "Podsumowanie kursu",
                                        Duration = "00:02:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 256,
                                        Name = "Dodatkowe materiały",
                                        Duration = "Dev-hobby.pl"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 30,
                                Name = "Z Całkiem Innej Beczki",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 257,
                                        Name = "Canva",
                                        Duration = "00:16:11"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 258,
                                        Name = "Nozbe",
                                        Duration = "00:18:28"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 259,
                                        Name = "Evernote",
                                        Duration = "00:12:26"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 260,
                                        Name = "Generator Kalendarzy",
                                        Duration = "00:06:58"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 261,
                                        Name = "Smash i WeTransfer",
                                        Duration = "00:09:13"
                                    }
                                }
                            }
                        }
                    }
                },
                Faq = new List<Faq>
                {
                    new Faq
                    {
                        FaqId = 10,
                        Question = "Co to jest abstrakcja?",
                        Answer = "Abstrakcja opisuje jednostkę w prosty sposób, ignorując nieistotne szczegóły."
                    },
                    new Faq
                    {
                        FaqId = 11,
                        Question = "Co to jest właściwość automatycznie wdrażana?",
                        Answer = "Jest to skrót do tworzenia właściwości C# z ukrytym polem."
                    },
                    new Faq
                    {
                        FaqId = 12,
                        Question = "Jak zbudowana jest sygnatura metody?",
                        Answer = "Składa się z nazwy i typu każdego z jej parametrów formalnych"
                    },
                    new Faq
                    {
                        FaqId = 13,
                        Question = "Co jest zasada oddzielania obowiazków?",
                        Answer = "Dekompozycja aplikacji na części. Każda część jest odpowiedzialna za osobny problem. Definiowanie części przy minimalnym zachodzeniu na siebie."
                    }
                },
                Announcements = new List<Announcement>
                {
                    new Announcement
                    {
                        AnnouncementId = 9,
                        Content = "Kod źródłowy dostępny na githubie : https://github.com/mariuszjurczenko/Kaczorek"
                    }
                },
                Opinions = new List<Opinion>
                {
                    new Opinion
                    {
                        OpinionId = 6,
                        Content = "Kurs pomógł mi zrozumieć w jaki sposób tworzy się odpowiednie klasy i jak można sprawdzić ich działanie za pomocą testów automatycznych. Prowadzący spokojnie i logicznie wprowadza w zagadnienia programowania zorientowanego obiektowo, wspierając je praktycznymi przykładami. Polecam.",
                        NumberOfStars = 5
                    },
                    new Opinion
                    {
                        OpinionId = 7,
                        Content = "ok. Świetny kurs! Po prostu.",
                        NumberOfStars = 5
                    }
                },
                Category = _categoryRepository.AllCategories.ToList()[0]
            },
            new Course
            {
                CourseId = 5,
                Name = "Seria Programista C# – część 3 – Najlepsze Praktyki Podstawy Języka",
                Author = "Mariusz Jurczenko",
                Price = 100,
                ImageUrl = "https://dev-hobby.pl/wordpress/wp-content/uploads/2020/09/Programista-C-Part3.png",
                ImageThumbnailUrl = "https://dev-hobby.pl/wordpress/wp-content/uploads/2020/09/Programista-C-Part3-300x169.png",
                IsCourseOfTheMonth = false,
                IsRecommended = true,
                Description = new Description
                {
                    DescriptionId = 5,
                    Name= "C# Najlepsze Praktyki – Podstawy języka",
                    WhatWillYouLearn = new List<WhatWillYouLearn>
                    {
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 34,
                            Content = "Gdy nauczysz się podstaw C#, to co zrobić dalej?"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 35,
                            Content = "Pomyśl o tym kursie jako o swojej praktyce."
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 36,
                            Content = "C# Najlepsze Praktyki: podstawy jezyka."
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 37,
                            Content = "Jak budować dobre klasy, pola, właściwości, metody."
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 38,
                            Content = "Zobaczysz kiedy używać klas statycznych, klasy singletony."
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 39,
                            Content = "Overloading metod lub Overriding metod?"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 40,
                            Content = "Te tematy poprowadzą cię po ścieżce od ucznia do wykwalifikowanego programisty."
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 41,
                            Content = "Wiele przydatnych wskazówek i dobrych praktyk."
                        }
                    },
                    Requirements = new List<Requirement>
                    {
                        new Requirement
                        {
                            RequirementId = 7,
                            Content = "Chęć nauki programowania i dobrej zabawy !!!"
                        },
                        new Requirement
                        {
                            RequirementId = 8,
                            Content = "C# Podstawy programowania"
                        },
                    },
                    WhoIsThisCourseFor = new List<WhoIsThisCourseFor>
                    {
                        new WhoIsThisCourseFor
                        {
                            WhoIsThisCourseForId = 20,
                            Content = "Programiści C#"
                        },
                        new WhoIsThisCourseFor
                        {
                            WhoIsThisCourseForId = 21,
                            Content = "Gdy nauczysz się podstaw C#, to co zrobić dalej?"
                        },
                        new WhoIsThisCourseFor
                        {
                            WhoIsThisCourseForId = 22,
                            Content = "Chcesz rozwijać swoje umiejętności poza podstawy?"
                        },
                        new WhoIsThisCourseFor
                        {
                            WhoIsThisCourseForId = 23,
                            Content = "Te tematy poprowadzą cię po ścieżce od ucznia do wykwalifikowanego programisty."
                        },
                    },
                    Content = "Kiedy po raz pierwszy zacząłem swoją kariera programistyczna, szybko dowiedziałem się, że jest duża różnica między wiedzą, jak pisać kod a wiedzą jak dobrze napisać kod, i tutaj leży wyzwanie. Celem tego kursu jest nauka najlepszych praktyk podczas używania podstawowych funkcji języka C#. Prawie wszystko, co tworzymy z C# jest klasą. Najtrudniejsze jest określenie właściwych klas dla każdej warstwy aplikacji. Będziemy badać warstwy aplikacji a następnie spojrzymy na różne typy klas, które możemy stworzyć. Przyjrzymy się również testom jednostkowym. Następnym krokiem jest budowanie dobrych klasy. Przeanalizujemy kod który należy do klasy i spojrzymy na przestrzenie nazw, klasy statyczne i klasy singleton. Klasy nie robią niczego, dopóki nie zaczniemy z nich korzystać, więc dalej przyjrzymy się najlepszym praktykom do korzystania z klas, w tym inicjalizacji obiektu, lazyloading, i nowemu operatorowi warunkowemu. W ramach klasy dane są przechowywane w polach. Zbadamy jak prawidłowo definiować pola, w tym pola zaplecza, stałe i pola tylko do odczytu. Kiedy już mamy dane w naszych pola, chcemy chronić te pola z właściwościami. Omówimy najlepsze praktyki dotyczące korzystania z automatycznych właściwości. Metody zapewniają operacje dla klasy, więc większość kodu, który piszemy, będzie w ramach tych metod. Będziemy patrzeć kiedy, dlaczego i na najlepsze praktyki tworzenia dobre metody, w tym przeciążanie metod, nadpisywanie metod, metody łancuchowe. Większość metod wymaga pewnych danych, i te dane są często przekazywane do metoda przez parametry. Będziemy patrzeć na najlepsze praktyki dotyczące określania jasnych parametrów metody, w tym nazwane parametry, parametry wyliczeniowe, parametry opcjonalne i parametry ref i out. Wiekszość danych w aplikacji jest przechowywana w ciągach tekstowych, więc omówimy najlepsze praktyki dla obsługi ciągów tekstowych, w tym sprawdzanie wartości null, formatowanie ciągów tekstowych, nową funkcje interpolacji ciągów i StringBuilder.",
                },
                CourseContent = new List<Content>
                {
                    new Content
                    {
                        ContentId = 5,
                        Chapters = new List<Chapter>
                        {
                            new Chapter
                            {
                                ChapterId = 31,
                                Name = "Wprowadzenie",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 262,
                                        Name = "Wprowadzenie",
                                        Duration = "00:05:12"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 263,
                                        Name = "Wymagania Wstępne",
                                        Duration = "00:10:32"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 264,
                                        Name = "Pliki do kursu",
                                        Duration = "00:20:13"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 265,
                                        Name = "Konspekt Szkolenia",
                                        Duration = "00:26:37"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 266,
                                        Name = "Quiz",
                                        Duration = "3 pytania"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 32,
                                Name = "Definiowanie Właściwych Klas",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 267,
                                        Name = "Wprowadzenie",
                                        Duration = "00:26:04"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 268,
                                        Name = "Architektura Aplikacji",
                                        Duration = "00:38:43"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 269,
                                        Name = "Architektura Aplikacji – Demo",
                                        Duration = "00:25:34"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 270,
                                        Name = "Co To Jest Klasa",
                                        Duration = "00:23:04"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 271,
                                        Name = "Rodzaje Klas",
                                        Duration = "00:24:54"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 272,
                                        Name = "Testy Jednostkowe",
                                        Duration = "00:22:53"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 273,
                                        Name = "Tworzymy Klasy",
                                        Duration = "00:20:09"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 274,
                                        Name = "Testy Jednostkowe – Demo",
                                        Duration = "00:20:09"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 275,
                                        Name = "Często Zadawane Pytania",
                                        Duration = "00:20:09"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 276,
                                        Name = "Quiz",
                                        Duration = "4 pytania"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 33,
                                Name = "Budowanie Dobrych Klas",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 277,
                                        Name = "Wprowadzenie",
                                        Duration = "00:17:45"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 278,
                                        Name = "SBudowanie Klasy",
                                        Duration = "00:19:31"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 279,
                                        Name = "Budowanie Klasy – Demo",
                                        Duration = "00:37:12"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 280,
                                        Name = "Definiowanie Konstruktorów",
                                        Duration = "00:23:58"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 281,
                                        Name = "Definiowanie Konstruktorów – Demo",
                                        Duration = "00:27:28"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 282,
                                        Name = "Konstruktor Najlepsze Praktyki",
                                        Duration = "00:30:23"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 283,
                                        Name = "Przestrzenie Nazw",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 284,
                                        Name = "Budowanie Klasy Statycznej",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 285,
                                        Name = "Budowanie Klasy Singelton",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 286,
                                        Name = "PCzęsto Zadawane Pytania",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 287,
                                        Name = "Quiz",
                                        Duration = "3 pytania"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 34,
                                Name = "Dostęp I Korzystanie Z Klas",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 288,
                                        Name = "Wprowadzenie",
                                        Duration = "00:35:44"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 289,
                                        Name = "Referencje I Using",
                                        Duration = "00:24:43"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 290,
                                        Name = "Używanie Klasy",
                                        Duration = "00:19:39"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 291,
                                        Name = "Dostęp Do Klasy",
                                        Duration = "00:21:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 292,
                                        Name = "Tworzenie Obiektów Powiązanych",
                                        Duration = "00:21:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 293,
                                        Name = "Null – Kontrola",
                                        Duration = "00:21:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 294,
                                        Name = "Null – Kontrola",
                                        Duration = "00:21:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 295,
                                        Name = "Quiz",
                                        Duration = "3 pytania"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 35,
                                Name = "Definijowanie Odpowiednich Pól",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 296,
                                        Name = "Wprowadzenie",
                                        Duration = "00:21:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 297,
                                        Name = "Pola",
                                        Duration = "00:13:08"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 298,
                                        Name = "Typy Nullable",
                                        Duration = "00:24:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 299,
                                        Name = "Stałe",
                                        Duration = "00:17:59"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 300,
                                        Name = "Pola Tylko Do Odczytu",
                                        Duration = "00:14:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 301,
                                        Name = "Stała A Pole Tylko Do Odczytu",
                                        Duration = "00:22:47"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 302,
                                        Name = "Często Zadawane Pytania",
                                        Duration = "00:22:47"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 303,
                                        Name = "Quiz",
                                        Duration = "4 pytania"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 36,
                                Name = "Tworzenie Dobrych Właściwosci",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 304,
                                        Name = "Wprowadzenie",
                                        Duration = "00:21:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 305,
                                        Name = "Właściwości – Geter",
                                        Duration = "00:13:08"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 306,
                                        Name = "Właściwości – Seter",
                                        Duration = "00:24:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 307,
                                        Name = "Automatycznie Implementowane Właściwości",
                                        Duration = "00:17:59"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 308,
                                        Name = "Właściwości Dostępność",
                                        Duration = "00:14:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 309,
                                        Name = "Dodatkowe Zastosowania Właściwości",
                                        Duration = "00:22:47"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 310,
                                        Name = "Skrót Dla Składni",
                                        Duration = "00:21:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 311,
                                        Name = "Zalety Właściwości",
                                        Duration = "00:13:08"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 312,
                                        Name = "BCzęsto Zadawane Pytania",
                                        Duration = "00:24:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 313,
                                        Name = "Quiz",
                                        Duration = "4 pytania"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 37,
                                Name = "Tworzenie Dobrych Metod",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 314,
                                        Name = "Wprowadzenie",
                                        Duration = "00:21:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 315,
                                        Name = "Budowanie Metod – Sygnatura Metody",
                                        Duration = "00:13:08"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 316,
                                        Name = "Budowanie Metod – Ciało Metody I Wartość Zwracana",
                                        Duration = "00:24:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 317,
                                        Name = "Budowanie Metod – Demo",
                                        Duration = "00:17:59"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 318,
                                        Name = "Budowanie Metod – Demo cz.2",
                                        Duration = "00:14:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 319,
                                        Name = "Właściwość Czy Metoda",
                                        Duration = "00:22:47"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 320,
                                        Name = "Przeciążanie Metod",
                                        Duration = "00:21:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 321,
                                        Name = "Metoda Łańcuchowa",
                                        Duration = "00:13:08"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 322,
                                        Name = "Nadpisywanie Metody",
                                        Duration = "00:14:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 323,
                                        Name = "Expression Bodied Methods",
                                        Duration = "00:14:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 324,
                                        Name = "Często Zadawane Pytania",
                                        Duration = "00:14:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 325,
                                        Name = "Quiz",
                                        Duration = "4 pytania"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 38,
                                Name = "Określanie Parametrów Metody",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 326,
                                        Name = "Wprowadzenie",
                                        Duration = "00:21:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 327,
                                        Name = "Poprawianie Parametrów W Sygnaturze Metody",
                                        Duration = "00:13:08"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 328,
                                        Name = "Nazwane Argumenty",
                                        Duration = "00:24:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 329,
                                        Name = "Definiowanie Parametrów Wyliczeniowych",
                                        Duration = "00:17:59"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 330,
                                        Name = "Opcjonalne Parametry",
                                        Duration = "00:14:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 331,
                                        Name = "Ref I Out",
                                        Duration = "00:22:47"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 332,
                                        Name = "Często Zadawane Pytania",
                                        Duration = "00:21:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 333,
                                        Name = "Quiz",
                                        Duration = "3 pytania"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 39,
                                Name = "Obsługa Ciagów Tekstowych (String)",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 334,
                                        Name = "Wprowadzenie",
                                        Duration = "00:21:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 335,
                                        Name = "Metody .Net Klasy String",
                                        Duration = "00:13:08"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 336,
                                        Name = "Obsługa Null",
                                        Duration = "00:24:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 337,
                                        Name = "Dosłowne Ciągi Tekstowe",
                                        Duration = "00:17:59"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 338,
                                        Name = "Formatowanie Ciągów Tekstowych",
                                        Duration = "00:14:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 339,
                                        Name = "Interpolacja Łańcuchów Tekstowych",
                                        Duration = "00:22:47"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 340,
                                        Name = "Budowanie Długich Ciągów Tekstowych",
                                        Duration = "00:21:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 341,
                                        Name = "Często Zadawane Pytania",
                                        Duration = "00:13:08"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 342,
                                        Name = "Quiz",
                                        Duration = "4 pytania"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 343,
                                        Name = "Podsumowanie kursu",
                                        Duration = "33 pytania"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 344,
                                        Name = "Dodatkowe materiały",
                                        Duration = "Dev-hobby.pl"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 40,
                                Name = "Z Całkiem Innej Beczki",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 345,
                                        Name = "Canva",
                                        Duration = "00:16:11"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 346,
                                        Name = "Nozbe",
                                        Duration = "00:18:28"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 347,
                                        Name = "Evernote",
                                        Duration = "00:12:26"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 348,
                                        Name = "Generator Kalendarzy",
                                        Duration = "00:06:58"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 349,
                                        Name = "Smash i WeTransfer",
                                        Duration = "00:09:13"
                                    }
                                }
                            }
                        }
                    }
                },
                Faq = new List<Faq>
                {
                    new Faq
                    {
                        FaqId = 14,
                        Question = "Dlaczego architektura warstwowa jest ważna?",
                        Answer = "Oddziela aplikację na komponenty, które są łatwiejsze do tworzenia, zmiany, rozszerzania, ponownego wykorzystania i utrzymania."
                    },
                    new Faq
                    {
                        FaqId = 15,
                        Question = "Co to jest singleton?",
                        Answer = "Klasa, która udostępnia tylko jedno wystąpienie samej siebie."
                    },
                    new Faq
                    {
                        FaqId = 16,
                        Question = "Kiedy należy używać stałej w aplikacji?",
                        Answer = "Podczas definiowania pola z prostym typem danych, który nigdy się nie zmieni."
                    },
                    new Faq
                    {
                        FaqId = 17,
                        Question = "W jaki sposób własciwość chroni pole?",
                        Answer = "Z kodem w getterze lub setterze i z odpowiednimi modyfikatorami dostępności."
                    }
                },
                Announcements = new List<Announcement>
                {
                    new Announcement
                    {
                        AnnouncementId = 10,
                        Content = "Kod źródłowy dostępny na githubie : https://github.com/mariuszjurczenko/DevHobbyApp"
                    }
                },
                Opinions = new List<Opinion>
                {
                    new Opinion
                    {
                        OpinionId = 8,
                        Content = "Kurs pomógł mi zrozumieć w jaki sposób tworzy się odpowiednie klasy i jak można sprawdzić ich działanie za pomocą testów automatycznych. Prowadzący spokojnie i logicznie wprowadza w zagadnienia programowania zorientowanego obiektowo, wspierając je praktycznymi przykładami. Polecam.",
                        NumberOfStars = 5
                    }
                },
                Category = _categoryRepository.AllCategories.ToList()[3]
            },
            new Course
            {
                CourseId = 6,
                Name = "Seria Programista C# – część 4 – Wprowadzenie Do Kolekcji",
                Author = "Mariusz Jurczenko",
                Price = 100,
                ImageUrl = "https://dev-hobby.pl/wordpress/wp-content/uploads/2020/09/Programista-C-Part4.png",
                ImageThumbnailUrl = "https://dev-hobby.pl/wordpress/wp-content/uploads/2020/09/Programista-C-Part3-300x169.png",
                IsCourseOfTheMonth = false,
                IsRecommended = true,
                Description = new Description
                {
                    DescriptionId = 6,
                    Name= "Wprowadzenie Do Kolekcji C#",
                    WhatWillYouLearn = new List<WhatWillYouLearn>
                    {
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 42,
                            Content = "Jak kodować za pomocą tablic."
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 43,
                            Content = " Jak kodować za pomocą list."
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 44,
                            Content = "Jak kodować za pomocą kolejki."
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 45,
                            Content = "Jak kodować za pomocą stosu."
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 46,
                            Content = "Jak kodować za pomocą słownika."
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 47,
                            Content = "LINQ."
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 48,
                            Content = "Gra Kólko i krzyżyk."
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 49,
                            Content = "Wiele przydatnych wskazówek i dobrych praktyk."
                        }
                    },
                    Requirements = new List<Requirement>
                    {
                        new Requirement
                        {
                            RequirementId = 9,
                            Content = "Chęć nauki programowania i dobrej zabawy !!!"
                        },
                        new Requirement
                        {
                            RequirementId = 10,
                            Content = "C# Podstawy programowania"
                        },
                        new Requirement
                        {
                            RequirementId = 11,
                            Content = "Pisać proste aplikacje w języku C#"
                        },
                    },
                    WhoIsThisCourseFor = new List<WhoIsThisCourseFor>
                    {
                        new WhoIsThisCourseFor
                        {
                            WhoIsThisCourseForId = 24,
                            Content = "Początkujący programiści języka C#."
                        },
                        new WhoIsThisCourseFor
                        {
                            WhoIsThisCourseForId = 25,
                            Content = "Gdy nauczysz się podstaw C#, to co zrobić dalej?"
                        },
                        new WhoIsThisCourseFor
                        {
                            WhoIsThisCourseForId = 26,
                            Content = "Chcesz rozwijać swoje umiejętności poza podstawy?"
                        }
                    },
                    Content = "W tym kursie pokażę Ci, jak kodować za pomocą prawdopodobnie najbardziej przydatnych i najczęściej używanych kolekcji, takich jak: tablica, lista, stos, kolejka i słownik oraz, co ważne, kiedy używać każdej z tych kolekcji. Nauczę cię dobrych technik wykorzystywania operacji kolekcji, takich jak wyszukiwanie, wyliczanie i modyfikowanie danych w kolekcjach, a nawet uzyskasz bardzo szybki przegląd tego, w jaki sposób LINQ może pomóc w wydobyciu danych z kolekcji. Pod koniec tego kursu powinieneś być w stanie manipulować prostymi kolekcjami w celu odpowiedniego przechowywania danych w różnych rodzajach scenariuszy, które najczęściej pojawiają się podczas pisania aplikacji i mogą pojawić się podczas pisania.",
                },
                CourseContent = new List<Content>
                {
                    new Content
                    {
                        ContentId = 6,
                        Chapters = new List<Chapter>
                        {
                            new Chapter
                            {
                                ChapterId = 41,
                                Name = "Tablice",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 350,
                                        Name = "Wprowadzenie",
                                        Duration = "00:05:12"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 351,
                                        Name = "Co To Jest Kolekcja",
                                        Duration = "00:10:32"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 352,
                                        Name = "Tablica",
                                        Duration = "00:20:13"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 353,
                                        Name = "Foreach",
                                        Duration = "00:26:37"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 354,
                                        Name = "Wybieranie Pojedynczego Elementu",
                                        Duration = "00:05:12"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 355,
                                        Name = "Edycja Tablicy",
                                        Duration = "00:10:32"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 356,
                                        Name = "Debugowanie",
                                        Duration = "00:20:13"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 357,
                                        Name = "Tablica A Inne Kolekcje",
                                        Duration = "00:26:37"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 358,
                                        Name = "Quiz",
                                        Duration = "4 pytania"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 42,
                                Name = "Tablice Praktyczny Przykład",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 359,
                                        Name = "Wprowadzenie",
                                        Duration = "00:26:04"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 360,
                                        Name = "Importowanie Danych Z Pliku",
                                        Duration = "00:38:43"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 361,
                                        Name = "Tworzenie Instancji Tablicy",
                                        Duration = "00:25:34"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 362,
                                        Name = "Plik CSV",
                                        Duration = "00:23:04"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 363,
                                        Name = "Analiza Linii CSV",
                                        Duration = "00:24:54"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 364,
                                        Name = "Wypełnianie Tablicy",
                                        Duration = "00:22:53"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 365,
                                        Name = "Tworzenie Wystąpienia Tablicy",
                                        Duration = "00:20:09"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 366,
                                        Name = "Quiz",
                                        Duration = "4 pytania"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 43,
                                Name = "Lista",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 367,
                                        Name = "Wprowadzenie",
                                        Duration = "00:17:45"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 368,
                                        Name = "Lista Jest Bardziej Elastyczna",
                                        Duration = "00:19:31"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 369,
                                        Name = "List",
                                        Duration = "00:37:12"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 370,
                                        Name = "Dodawanie Elementu",
                                        Duration = "00:23:58"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 371,
                                        Name = "List To Typ Ogólny",
                                        Duration = "00:27:28"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 372,
                                        Name = "Importowanie Danych Z Pliku",
                                        Duration = "00:30:23"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 373,
                                        Name = "Liczenie Elementów",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 374,
                                        Name = "Wstawianie Elementu",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 375,
                                        Name = "Wyszukiwanie Elementu",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 376,
                                        Name = "Usuwanie Elementu",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 377,
                                        Name = "Wydajność",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 378,
                                        Name = "Quiz",
                                        Duration = "4 pytania"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 44,
                                Name = "Słownik",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 379,
                                        Name = "Wprowadzenie",
                                        Duration = "00:35:44"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 380,
                                        Name = "Dictionary",
                                        Duration = "00:24:43"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 381,
                                        Name = "Tworzenie Instancji Słownika",
                                        Duration = "00:19:39"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 382,
                                        Name = "Dodawanie Elementów",
                                        Duration = "00:21:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 383,
                                        Name = "Wyszukiwanie Elementów",
                                        Duration = "00:21:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 384,
                                        Name = "Wyliczanie Elementów",
                                        Duration = "00:21:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 385,
                                        Name = "Inicjaliztor Słownika",
                                        Duration = "00:21:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 386,
                                        Name = "Klucz Jest Unikalny",
                                        Duration = "00:21:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 387,
                                        Name = "Wyszukiwanie Elementów TryGetValue",
                                        Duration = "00:21:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 388,
                                        Name = "Importowanie Miast Do Słownika",
                                        Duration = "00:21:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 389,
                                        Name = "Quiz",
                                        Duration = "3 pytania"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 45,
                                Name = "Kolejka I Stos",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 390,
                                        Name = "Wprowadzenie",
                                        Duration = "00:21:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 391,
                                        Name = "Kolejka",
                                        Duration = "00:13:08"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 392,
                                        Name = "Dodawanie Elementów",
                                        Duration = "00:24:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 293,
                                        Name = "Pobieranie Elementów",
                                        Duration = "00:17:59"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 394,
                                        Name = "Podgląd Elementu",
                                        Duration = "00:14:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 395,
                                        Name = "Wyszukiwanie Elementu",
                                        Duration = "00:22:47"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 396,
                                        Name = "Konwersja Do Tablicy",
                                        Duration = "00:22:47"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 397,
                                        Name = "Wyczyszczenie Kolejki",
                                        Duration = "00:17:59"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 398,
                                        Name = "Stos",
                                        Duration = "00:21:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 399,
                                        Name = "Dodawanie Elementów",
                                        Duration = "00:13:08"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 400,
                                        Name = "Pobieranie Elementów",
                                        Duration = "00:24:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 401,
                                        Name = "Podgląd Elementu",
                                        Duration = "00:17:59"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 402,
                                        Name = "Wyszukiwanie Elementu",
                                        Duration = "00:14:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 403,
                                        Name = "Konwersja Do Tablicy",
                                        Duration = "00:22:47"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 404,
                                        Name = "Wyczyszczenie Stosu",
                                        Duration = "00:22:47"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 405,
                                        Name = "Importowanie Danych Z Pliku",
                                        Duration = "00:17:59"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 406,
                                        Name = "Quiz",
                                        Duration = "4 pytania"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 46,
                                Name = "Praca Z Listami",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 407,
                                        Name = "Wprowadzenie",
                                        Duration = "00:21:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 408,
                                        Name = "Wyliczanie For a Foreach",
                                        Duration = "00:13:08"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 409,
                                        Name = "Iterowanie Wybranych Elementów",
                                        Duration = "00:24:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 410,
                                        Name = "Grupowanie Elementów",
                                        Duration = "00:17:59"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 411,
                                        Name = "Wyliczanie Wstecz",
                                        Duration = "00:14:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 412,
                                        Name = "Usuwanie Elementów",
                                        Duration = "00:22:47"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 413,
                                        Name = "RemoveAll",
                                        Duration = "00:21:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 414,
                                        Name = "Quiz",
                                        Duration = "4 pytania"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 47,
                                Name = "LINQ",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 415,
                                        Name = "Wprowadzenie",
                                        Duration = "00:21:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 416,
                                        Name = "Ograniczenie Liczby Wyników",
                                        Duration = "00:13:08"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 417,
                                        Name = "Sortowanie Danych",
                                        Duration = "00:24:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 418,
                                        Name = "Łączenie Metod",
                                        Duration = "00:17:59"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 419,
                                        Name = "Filtrowanie Danych",
                                        Duration = "00:14:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 420,
                                        Name = "Inne Operacje",
                                        Duration = "00:22:47"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 421,
                                        Name = "Składnia Zapytań",
                                        Duration = "00:21:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 422,
                                        Name = "Porównanie Linq, For I Metod",
                                        Duration = "00:13:08"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 423,
                                        Name = "Quiz",
                                        Duration = "4 pytania"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 48,
                                Name = "Kolekcje Kolekcji",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 424,
                                        Name = "Wprowadzenie",
                                        Duration = "00:21:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 425,
                                        Name = "Grupowanie Danych Za Pomocą Słownika",
                                        Duration = "00:13:08"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 426,
                                        Name = "Importowanie Miast Do Słownika",
                                        Duration = "00:24:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 427,
                                        Name = "Wyświetlanie Danych Ze Słownika",
                                        Duration = "00:17:59"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 428,
                                        Name = "Poszczępiona Tablica",
                                        Duration = "00:14:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 429,
                                        Name = "Kółko I Krzyżyk",
                                        Duration = "00:22:47"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 430,
                                        Name = "Kółko I Krzyżyk część 2",
                                        Duration = "00:21:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 431,
                                        Name = "Kółko I Krzyżyk część 3",
                                        Duration = "00:17:59"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 432,
                                        Name = "Kółko I Krzyżyk część 4",
                                        Duration = "00:14:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 433,
                                        Name = "Tablice Wielowymiarowe",
                                        Duration = "00:22:47"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 434,
                                        Name = "Zakończenie",
                                        Duration = "00:21:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 435,
                                        Name = "Quiz",
                                        Duration = "3 pytania"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 436,
                                        Name = "Podsumowanie Kursu",
                                        Duration = "38 pytania"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 437,
                                        Name = "Dodatkowe materiały",
                                        Duration = "Dev-hobby.pl"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 49,
                                Name = "Z Całkiem Innej Beczki",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 438,
                                        Name = "Canva",
                                        Duration = "00:16:11"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 439,
                                        Name = "Nozbe",
                                        Duration = "00:18:28"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 440,
                                        Name = "Evernote",
                                        Duration = "00:12:26"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 441,
                                        Name = "Generator Kalendarzy",
                                        Duration = "00:06:58"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 442,
                                        Name = "Smash i WeTransfer",
                                        Duration = "00:09:13"
                                    }
                                }
                            }
                        }
                    }
                },
                Faq = new List<Faq>
                {
                    new Faq
                    {
                        FaqId = 18,
                        Question = "Jaka jest główna różnica między metodami Listy: Add() i Insert() ?",
                        Answer = "Add() zawsze dołącza nowy element na końcu listy, Insert() może umieścić element w dowolnym miejscu na liście."
                    },
                    new Faq
                    {
                        FaqId = 19,
                        Question = "Wyliczanie elementów w kolekcji jest często wykonywane za pomocą pętli foreach. Dlaczego zamiast tego używać pętli for?",
                        Answer = "Aby kontrolować kolejność wyliczania elementów."
                    }
                },
                Announcements = new List<Announcement>
                {
                    new Announcement
                    {
                        AnnouncementId = 11,
                        Content = "Kod źródłowy dostępny na githubie : https://github.com/mariuszjurczenko/BeginningCsharpCollections"
                    }
                },
                Opinions = new List<Opinion>
                {
                    new Opinion
                    {
                        OpinionId = 9,
                        Content = "Kurs pomógł mi zrozumieć kolekcje w csharp. Prowadzący spokojnie i logicznie wprowadza w zagadnienia. Bardzo dobry kurs, polecam.",
                        NumberOfStars = 5
                    }
                },
                Category = _categoryRepository.AllCategories.ToList()[0]
            },
            new Course
            {
                CourseId = 7,
                Name = "Seria Programista C# – część 5 – Generics",
                Author = "Mariusz Jurczenko",
                Price = 100,
                ImageUrl = "https://dev-hobby.pl/wordpress/wp-content/uploads/2020/09/Programista-C-Part5.png",
                ImageThumbnailUrl = "https://dev-hobby.pl/wordpress/wp-content/uploads/2020/09/Programista-C-Part5-300x169.png",
                IsCourseOfTheMonth = false,
                IsRecommended = true,
                Description = new Description
                {
                    DescriptionId = 7,
                    Name= "C# Generics",
                    WhatWillYouLearn = new List<WhatWillYouLearn>
                    {
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 50,
                            Content = "Podstawowe zasady, które powinieneś znać o typach Generycznych"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 51,
                            Content = "Pisać typy generyczne i generyczne interfejsy"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 52,
                            Content = "Pisać metody generyczne"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 53,
                            Content = "Pisać delegaty generyczne"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 54,
                            Content = "Zobaczysz wyrażenia lambda, metody rozszerzenia"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 55,
                            Content = "Zdarzenia i procedury obsługi zdarzeń"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 56,
                            Content = "Strategi, których możesz użyć, aby dodać ograniczenia do parametrów typu ogólnego"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 57,
                            Content = "Wiele przydatnych wskazówek i dobrych praktyk."
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 58,
                            Content = "Zbudujemy naszą własną wersjie kontenera wstrzykiwania zależności"
                        }
                    },
                    Requirements = new List<Requirement>
                    {
                        new Requirement
                        {
                            RequirementId = 12,
                            Content = "Chęć nauki programowania i dobrej zabawy !!!"
                        },
                        new Requirement
                        {
                            RequirementId = 13,
                            Content = "C# Podstawy programowania"
                        },
                        new Requirement
                        {
                            RequirementId = 14,
                            Content = "Pisać proste aplikacje w języku C#"
                        },
                    },
                    WhoIsThisCourseFor = new List<WhoIsThisCourseFor>
                    {
                        new WhoIsThisCourseFor
                        {
                            WhoIsThisCourseForId = 27,
                            Content = "Programiści języka C#"
                        },
                        new WhoIsThisCourseFor
                        {
                            WhoIsThisCourseForId = 28,
                            Content = "Gdy nauczysz się podstaw C#, to co zrobić dalej?"
                        },
                        new WhoIsThisCourseFor
                        {
                            WhoIsThisCourseForId = 29,
                            Content = "Chcesz rozwijać swoje umiejętności poza podstawy?"
                        }
                    },
                    Content = "W tym kursie pokażę Ci, wszystko, co powinieneś wiedzieć o typach Generycznych w języku C#, a może nawet trochę więcej. Rozdział. 1) Pokażę podstawowe zasady, które powinieneś znać o typach Generycznych, wyjaśnić dlaczego istnieją i jakie rodzaje problemów rozwiązują. Rozdział. 2) Następnie zagłębimy się w typy generyczne z perspektywy kogoś, kto musi pisać typy generyczne. Zaczniemy również używać i pisać generyczne interfejsy. Rozdział. 3) Następnie zajmiemy się użyciem parametrów typu ogólnego do generowania poszczególnych bloków kodu. Oznacza to, że przyjrzymy się metodom, delegatom generycznym, a także przyjrzymy się wyrażeniom lambda, metodom rozszerzenia, zdarzeniom i procedurom obsługi zdarzeń, z których wszystkie mogą używać parametrów typu ogólnego, aby można było pisać bloki kodu wielokrotnego użytku. Rozdział. 4) Następnie przyjrzymy się strategiom, których możesz użyć, aby dodać ograniczenia do parametrów typu ogólnego. Rozdział. 5) Następnie stworzymy interesujący kod z typami geneycznymi. Pokaże Ci, jak używać typów generycznych przy pisaniu kodu wykorzystującego refleksję. Zbudujemy naszą własną wersji kontenera wstrzykiwaniu zależności co będzie niezwykle edukacyjne. A nasz kontener, który zbudujemy, będzie wymagał oczywiście ogólnych parametrów.",
                },
                CourseContent = new List<Content>
                {
                    new Content
                    {
                        ContentId = 7,
                        Chapters = new List<Chapter>
                        {
                            new Chapter
                            {
                                ChapterId = 50,
                                Name = "Generic Types",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 443,
                                        Name = "Wprowadzenie",
                                        Duration = "00:05:12"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 444,
                                        Name = "Nasz Własny Stos",
                                        Duration = "00:10:32"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 445,
                                        Name = "Piszemy Testy Dla Naszego Stosu",
                                        Duration = "00:20:13"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 446,
                                        Name = "Użycie Naszego Stosu",
                                        Duration = "00:26:37"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 447,
                                        Name = "Object",
                                        Duration = "00:05:12"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 448,
                                        Name = "Kopiuj i Wklej",
                                        Duration = "00:10:32"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 449,
                                        Name = "Typy Generyczne",
                                        Duration = "00:20:13"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 450,
                                        Name = "Nasz Stos Generyczny",
                                        Duration = "00:26:37"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 451,
                                        Name = "Terminologia",
                                        Duration = "00:20:13"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 452,
                                        Name = "Podsumowanie",
                                        Duration = "00:26:37"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 453,
                                        Name = "Quiz",
                                        Duration = "4 pytania"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 51,
                                Name = "Generic Classes And Interfaces",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 454,
                                        Name = "Wprowadzenie",
                                        Duration = "00:26:04"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 455,
                                        Name = "Nowe Wymagania",
                                        Duration = "00:38:43"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 456,
                                        Name = "Nasz Własny Interface",
                                        Duration = "00:25:34"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 457,
                                        Name = "Nasza własna Kolekcja",
                                        Duration = "00:23:04"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 458,
                                        Name = "Nasz Kolejny Stos",
                                        Duration = "00:24:54"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 459,
                                        Name = "Kolejka Nadpisująca",
                                        Duration = "00:22:53"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 460,
                                        Name = "IEnumerable",
                                        Duration = "00:20:09"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 461,
                                        Name = "Interfejsy kolekcji",
                                        Duration = "00:23:04"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 462,
                                        Name = "CarComparer",
                                        Duration = "00:24:54"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 463,
                                        Name = "Czyszczenie",
                                        Duration = "00:22:53"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 464,
                                        Name = "Podsumowanie",
                                        Duration = "00:20:09"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 465,
                                        Name = "Quiz",
                                        Duration = "4 pytania"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 52,
                                Name = "Generic Methods And Delegates",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 466,
                                        Name = "Wprowadzenie",
                                        Duration = "00:17:45"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 467,
                                        Name = "Metody Generyczne",
                                        Duration = "00:19:31"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 468,
                                        Name = "Metody Rozszerzenia",
                                        Duration = "00:37:12"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 469,
                                        Name = "Refactoring",
                                        Duration = "00:23:58"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 470,
                                        Name = "Delegaty Generyczne",
                                        Duration = "00:27:28"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 471,
                                        Name = "Action",
                                        Duration = "00:30:23"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 472,
                                        Name = "Func",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 473,
                                        Name = "Predicate",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 474,
                                        Name = "Konwerter",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 475,
                                        Name = "Zdarzenia Generyczne",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 476,
                                        Name = "Podsumowanie",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 477,
                                        Name = "Quiz",
                                        Duration = "4 pytania"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 53,
                                Name = "Generic Constraints",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 478,
                                        Name = "Wprowadzenie",
                                        Duration = "00:35:44"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 479,
                                        Name = "Ograniczenia",
                                        Duration = "00:24:43"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 480,
                                        Name = "Model",
                                        Duration = "00:19:39"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 481,
                                        Name = "Cel Naszej Aplikacji",
                                        Duration = "00:21:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 482,
                                        Name = "Repozytorium i ograniczenia",
                                        Duration = "00:21:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 483,
                                        Name = "Repozytorium",
                                        Duration = "00:21:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 484,
                                        Name = "Ograniczenie Interfejsu",
                                        Duration = "00:21:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 485,
                                        Name = "Ograniczenia",
                                        Duration = "00:21:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 486,
                                        Name = "Kowariancja",
                                        Duration = "00:21:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 487,
                                        Name = "Kontrawariancja",
                                        Duration = "00:21:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 488,
                                        Name = "Podsumowanie",
                                        Duration = "00:21:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 489,
                                        Name = "Quiz",
                                        Duration = "3 pytania"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 54,
                                Name = "Generics And Reflection",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 490,
                                        Name = "Wprowadzenie",
                                        Duration = "00:21:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 491,
                                        Name = "Tworzenie Instancji Typów Ogólnych",
                                        Duration = "00:13:08"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 492,
                                        Name = "Wywoływanie Metod Ogólnych",
                                        Duration = "00:24:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 493,
                                        Name = "Nasz Własny Kontener",
                                        Duration = "00:17:59"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 494,
                                        Name = "Pierwsza Funkcja Naszego Kontenera",
                                        Duration = "00:14:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 495,
                                        Name = "Praca Z Konstruktorami",
                                        Duration = "00:22:47"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 496,
                                        Name = "Praca Z Niezwiązanymi Typami",
                                        Duration = "00:22:47"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 497,
                                        Name = "Podsumowanie",
                                        Duration = "00:17:59"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 498,
                                        Name = "Quiz",
                                        Duration = "3 pytania"
                                    },
                                     new Lesson
                                    {
                                        LessonId = 499,
                                        Name = "Podsumowanie kursu",
                                        Duration = "00:21:27"
                                    },
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 55,
                                Name = "Z Całkiem Innej Beczki",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 500,
                                        Name = "Canva",
                                        Duration = "00:16:11"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 501,
                                        Name = "Nozbe",
                                        Duration = "00:18:28"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 502,
                                        Name = "Evernote",
                                        Duration = "00:12:26"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 503,
                                        Name = "Generator Kalendarzy",
                                        Duration = "00:06:58"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 504,
                                        Name = "Smash i WeTransfer",
                                        Duration = "00:09:13"
                                    }
                                }
                            }
                        }
                    }
                },
                Faq = new List<Faq>
                {
                    new Faq
                    {
                        FaqId = 20,
                        Question = "Dlaczego powstały typy generyczne?",
                        Answer = "Celem było umożliwienie nam ponownego użycia większej ilości kodu, przy jednoczesnym zachowaniu bezpieczeństwa typów."
                    },
                    new Faq
                    {
                        FaqId = 21,
                        Question = "Czy możemy mieć interfejsy generyczne?",
                        Answer = "Tak."
                    }
                },
                Announcements = new List<Announcement>
                {
                    new Announcement
                    {
                        AnnouncementId = 12,
                        Content = "Kod źródłowy dostępny na githubie : https://github.com/mariuszjurczenko/Generics"
                    }
                },
                Opinions = new List<Opinion>
                {
                    new Opinion
                    {
                        OpinionId = 10,
                        Content = "Obszerne omówienie typów generycznych w C# z praktyczną prezentacją przeprowadzania testów jednostkowych. Polecam kurs prowadzony spokojnie a czasami nawet humorystycznie (w sposób chyba niezamierzony ale to dobrze bo \"uczy bawiąc\"). Wiele praktycznych wskazówek dotyczących środowiska Visual Studio.",
                        NumberOfStars = 5
                    }
                },
                Category = _categoryRepository.AllCategories.ToList()[0]
            },
            new Course
            {
                CourseId = 8,
                Name = "ASP.NET Core 2.1 MVC – Seria Web Developer – część 1",
                Author = "Mariusz Jurczenko",
                Price = 100,
                ImageUrl = "https://dev-hobby.pl/wordpress/wp-content/uploads/2020/09/ASP.NET-Core-2.1-MVC-Web-Devrloper.png",
                ImageThumbnailUrl = "https://dev-hobby.pl/wordpress/wp-content/uploads/2020/09/ASP.NET-Core-2.1-MVC-Web-Devrloper-300x169.png",
                IsCourseOfTheMonth = false,
                IsRecommended = true,
                Description = new Description
                {
                    DescriptionId = 8,
                    Name= "Budowanie pierwszej aplikacji ASP.NET Core 2.1 MVC z Visual Studio 2017",
                    WhatWillYouLearn = new List<WhatWillYouLearn>
                    {
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 59,
                            Content = "Będziesz wiedział, jak zbudować pełną aplikację za pomocą ASP_NET Core 2.1 MVC"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 60,
                            Content = "Zdobędziesz umiejętności, które zapewnią Ci szansę na wspaniałą karierę zawodową"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 61,
                            Content = "W krótkim czasie poznasz zupełnie od podstaw proces budowania aplikacji ASP_NET Core 2.1 MVC"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 62,
                            Content = "Opanujesz liczne pojęcia, koncepcje oraz techniki, których znajomość jest niezbędna podczas tworzenia nowoczesnych aplikacji"
                        }
                    },
                    Requirements = new List<Requirement>
                    {
                        new Requirement
                        {
                            RequirementId = 15,
                            Content = "Chęć nauki programowania i dobrej zabawy !!!"
                        },
                        new Requirement
                        {
                            RequirementId = 16,
                            Content = "Przed rozpoczęciem tego kursu powinieneś zapoznać się z podstawami C#"
                        }
                    },
                    WhoIsThisCourseFor = new List<WhoIsThisCourseFor>
                    {
                        new WhoIsThisCourseFor
                        {
                            WhoIsThisCourseForId = 30,
                            Content = "Początkujący programista AspNet Core"
                        },
                        new WhoIsThisCourseFor
                        {
                            WhoIsThisCourseForId = 31,
                            Content = "Początkujący programiści AspNet Mvc"
                        },
                        new WhoIsThisCourseFor
                        {
                            WhoIsThisCourseForId = 32,
                            Content = "Chcesz w krótkim czasie poznać zupełnie od podstaw kompletny proces budowania aplikacji z ASP_NET Core"
                        },
                        new WhoIsThisCourseFor
                        {
                            WhoIsThisCourseForId = 33,
                            Content = "Chcesz w praktyce wykorzystać swoją znajomość języka C# i zdobyć umiejętności, które zapewnią Ci szansę na wspaniałą karierę zawodową"
                        },
                        new WhoIsThisCourseFor
                        {
                            WhoIsThisCourseForId = 34,
                            Content = "Chcesz opanować liczne pojęcia, koncepcje oraz techniki, których znajomość jest niezbędna podczas tworzenia nowoczesnych aplikacji"
                        }
                    },
                    Content = "W kursie będziemy budować naszą pierwszą aplikację ASP.NET Core 2.1 MVC z Visual Studio 2017. Ten kurs ma na celu dać ci praktyczny sposób, aby dowiedzieć się jak najwięcej o ASP.NET Core 2.1 MVC. Zbudujemy pełną aplikację w Visual Studio 2017. Dowiesz się jak robimy konfigurowanie witryny. Zobaczysz, jak zastosować wzór MVC, tworzyć model, repozytorium, budować widoki, pracować z prawdziwą bazą danych i wiele więcej. Niektóre z głównych tematów, które omówimy, to budowa w pełni działającej aplikacji, zaczynając od Plik -> Nowy Projekt. Dowiesz się o nowych funkcjach ASP.NET Core 2.1 MVC, takich jak : Tag helpers, dostęp do danych w bazie danych, przy użyciu Entity Framework Core 2, omówimy ASP.NET identity, aby umożliwić użytkownikom uwierzytelnianie w naszej witrynie. Pod koniec tego kursu będziecie wiedzieć, jak zbudować w pełni działającą, rzeczywistą aplikację przy użyciu ASP.NET Core 2.1 MVC w Visual Studio 2017.",
                },
                CourseContent = new List<Content>
                {
                    new Content
                    {
                        ContentId = 8,
                        Chapters = new List<Chapter>
                        {
                            new Chapter
                            {
                                ChapterId = 56,
                                Name = "Wprowadenie",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 505,
                                        Name = "Wprowadzenie",
                                        Duration = "00:05:12"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 506,
                                        Name = "Przegląd Kursu",
                                        Duration = "00:10:32"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 507,
                                        Name = "Ostateczna Aplikacja",
                                        Duration = "00:20:13"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 508,
                                        Name = "Co To Jest Asp.Net Core",
                                        Duration = "00:26:37"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 509,
                                        Name = "Przygotowanie Komputera Do Pracy",
                                        Duration = "00:05:12"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 510,
                                        Name = "Przygotowanie Komputera Do Pracy – Demo",
                                        Duration = "00:10:32"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 511,
                                        Name = "Podsumowanie",
                                        Duration = "00:26:37"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 57,
                                Name = "Konfigurowanie Witryny",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 512,
                                        Name = "Wprowadzenie",
                                        Duration = "00:26:04"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 513,
                                        Name = "Poznawanie Struktury Projektu",
                                        Duration = "00:38:43"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 514,
                                        Name = "Tworzenie Nowej Aplikacji – Demo",
                                        Duration = "00:25:34"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 515,
                                        Name = "Konfigurowanie Witryny",
                                        Duration = "00:23:04"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 516,
                                        Name = "NKonfigurowanie Witryny – Demo",
                                        Duration = "00:24:54"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 517,
                                        Name = "Podsumowanie",
                                        Duration = "00:20:09"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 58,
                                Name = "Tworzenie Pierwszej Strony Listy Samochodów",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 518,
                                        Name = "Wprowadzenie",
                                        Duration = "00:17:45"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 519,
                                        Name = "Wzorzec MVC",
                                        Duration = "00:19:31"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 520,
                                        Name = "Tworzenie Modelu I Repozytorium",
                                        Duration = "00:37:12"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 521,
                                        Name = "Tworzenie Modelu I Repozytorium – Demo",
                                        Duration = "00:23:58"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 522,
                                        Name = "Tworzenie Kontrolera",
                                        Duration = "00:27:28"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 523,
                                        Name = "Tworzenie Kontrolera - Demo",
                                        Duration = "00:30:23"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 524,
                                        Name = "Dodawanie Widoku",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 525,
                                        Name = "Dodawanie Widoku - Demo",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 526,
                                        Name = "Stylizacja Widoku",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 527,
                                        Name = "Stylizacja Widoku - Demo",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 528,
                                        Name = "Podsumowanie",
                                        Duration = "00:21:33"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 59,
                                Name = "Dodawanie Danych Za Pomocą Entity Framework Core",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 529,
                                        Name = "Wprowadzenie",
                                        Duration = "00:35:44"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 530,
                                        Name = "EF Core",
                                        Duration = "00:24:43"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 531,
                                        Name = "Dodanie EF Core Do Aplikacji",
                                        Duration = "00:19:39"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 532,
                                        Name = "Dodanie EF Core Do Aplikacji – Demo",
                                        Duration = "00:21:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 533,
                                        Name = "Inicjowanie Bazy Danych",
                                        Duration = "00:21:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 534,
                                        Name = "Inicjowanie Bazy Danych - Demo",
                                        Duration = "00:21:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 535,
                                        Name = "Modyfikowanie Modelu",
                                        Duration = "00:21:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 536,
                                        Name = "Modyfikowanie Modelu - Demo",
                                        Duration = "00:21:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 537,
                                        Name = "Podsumowanie",
                                        Duration = "00:21:50"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 60,
                                Name = "Dodawanie Nawigacji Do Witryny",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 538,
                                        Name = "Wprowadzenie",
                                        Duration = "00:21:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 539,
                                        Name = "Zrozumienie Nawigacji W MVC",
                                        Duration = "00:13:08"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 540,
                                        Name = "Dodawanie Nawigacji",
                                        Duration = "00:24:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 541,
                                        Name = "Dodawanie Nawigacji - Demo",
                                        Duration = "00:17:59"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 542,
                                        Name = "Podsumowanie",
                                        Duration = "00:17:59"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 61,
                                Name = "Tworzenie Formularza",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 543,
                                        Name = "Wprowadzenie",
                                        Duration = "00:21:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 544,
                                        Name = "Używanie Tag Helpers",
                                        Duration = "00:13:08"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 545,
                                        Name = "Tworzenie Formularza – Demo",
                                        Duration = "00:24:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 546,
                                        Name = "Wiązanie I Walidacja Modelu",
                                        Duration = "00:17:59"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 547,
                                        Name = "Sprawdzanie Poprawności Modelu – Demo",
                                        Duration = "00:17:59"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 548,
                                        Name = "Podsumowanie",
                                        Duration = "00:17:59"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 62,
                                Name = "Dodanie Możliwości Rejestracji I Logowania Do Witryny",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 549,
                                        Name = "Wprowadzenie",
                                        Duration = "00:21:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 550,
                                        Name = "Odkrywanie ASP.NET Core Identity",
                                        Duration = "00:13:08"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 551,
                                        Name = "Dodawanie ASP.NET Identity – Demo",
                                        Duration = "00:24:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 552,
                                        Name = "Dodawanie Uwierzytelniania Do Witryny",
                                        Duration = "00:17:59"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 553,
                                        Name = "Dodawanie Widoku Logowania i Widoku Rejestracji",
                                        Duration = "00:17:59"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 554,
                                        Name = "Autoryzacja Użytkowników",
                                        Duration = "00:17:59"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 555,
                                        Name = "Autoryzacja Użytkowników - Demo",
                                        Duration = "00:17:59"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 556,
                                        Name = "Podsumowanie",
                                        Duration = "00:17:59"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 63,
                                Name = "Operacje CRUD",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 557,
                                        Name = "CRUD Wykorzystanie Szablonu",
                                        Duration = "00:21:27"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 558,
                                        Name = "Repozytorium",
                                        Duration = "00:13:08"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 559,
                                        Name = "Kontroler",
                                        Duration = "00:24:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 560,
                                        Name = "Szczegóły",
                                        Duration = "00:17:59"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 561,
                                        Name = "Dodaj",
                                        Duration = "00:17:59"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 562,
                                        Name = "Edycja",
                                        Duration = "00:17:59"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 563,
                                        Name = "Usuń",
                                        Duration = "00:17:59"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 556,
                                        Name = "Przesyłanie Zdjęć – Formularz",
                                        Duration = "00:17:59"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 557,
                                        Name = "Przesyłanie Zdjęć",
                                        Duration = "00:17:59"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 558,
                                        Name = "Usuwanie Zdjęć",
                                        Duration = "00:17:59"
                                    },
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 64,
                                Name = "Z Całkiem Innej Beczki",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 559,
                                        Name = "Canva",
                                        Duration = "00:16:11"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 560,
                                        Name = "Nozbe",
                                        Duration = "00:18:28"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 561,
                                        Name = "Evernote",
                                        Duration = "00:12:26"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 562,
                                        Name = "Generator Kalendarzy",
                                        Duration = "00:06:58"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 563,
                                        Name = "Smash i WeTransfer",
                                        Duration = "00:09:13"
                                    }
                                }
                            }
                        }
                    }
                },
                Faq = new List<Faq>
                {
                    new Faq
                    {
                        FaqId = 22,
                        Question = "Pytanie 1",
                        Answer = "Odpowiedz na pierwszr czesto zadawane pytanie"
                    }
                },
                Announcements = new List<Announcement>
                {
                    new Announcement
                    {
                        AnnouncementId = 13,
                        Content = "Kod źródłowy dostępny na githubie : https://github.com/mariuszjurczenko/Komis"
                    }
                },
                Opinions = new List<Opinion>
                {
                    new Opinion
                    {
                        OpinionId = 11,
                        Content = "Obszerne omówienie tematu. Polecam kurs prowadzony spokojnie a czasami nawet humorystycznie",
                        NumberOfStars = 5
                    }
                },
                Category = _categoryRepository.AllCategories.ToList()[1]
            },
            new Course
            {
                CourseId = 9,
                Name = "HTML5, CSS, JavaScript, jQuery – Seria Web Developer – część 2",
                Author = "Mariusz Jurczenko",
                Price = 100,
                ImageUrl = "https://dev-hobby.pl/wordpress/wp-content/uploads/2020/09/HTML-CSS-JAVASCRIPT-JQUERY.png",
                ImageThumbnailUrl = "https://dev-hobby.pl/wordpress/wp-content/uploads/2020/09/HTML-CSS-JAVASCRIPT-JQUERY-300x169.png",
                IsCourseOfTheMonth = false,
                IsRecommended = false,
                Description = new Description
                {
                    DescriptionId = 9,
                    Name= "HTML5, CSS, JavaScript, jQuery Szybki Start dla .Net Core – Seria Web Developer część 2",
                    WhatWillYouLearn = new List<WhatWillYouLearn>
                    {
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 63,
                            Content = "Poznasz podstawy HTML"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 64,
                            Content = "Poznasz podstawy CSS"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 65,
                            Content = "Poznasz podstawy JavaScript"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 66,
                            Content = "Poznasz podstawy jQuery"
                        }
                    },
                    Requirements = new List<Requirement>
                    {
                        new Requirement
                        {
                            RequirementId = 17,
                            Content = "Chęć nauki i dobrej zabawy !!!"
                        }
                    },
                    WhoIsThisCourseFor = new List<WhoIsThisCourseFor>
                    {
                        new WhoIsThisCourseFor
                        {
                            WhoIsThisCourseForId = 35,
                            Content = "Początkujący twórca stron internetowych"
                        },
                        new WhoIsThisCourseFor
                        {
                            WhoIsThisCourseForId = 36,
                            Content = "Początkujący programista AspNet Core"
                        },
                        new WhoIsThisCourseFor
                        {
                            WhoIsThisCourseForId = 37,
                            Content = "Początkujący programiści AspNet Mvc"
                        }
                    },
                    Content = "Witam w szybkim kursie tworzenia stron WWW dla początkujących z HTML5, CSS, JavaScript i Jquery. Jeśli zaczynasz ten kurs, to wiedz że nauczysz się pewnych umiejętności związanych z tworzeniem stron internetowych. Ten kurs w szczególności pomoże Ci nauczyć się HTMLa, stylizacji strony za pomocą CSSa, a także obsługi kodu po stronie klienta za pomocą JavaScriptu i Jquery. Celem tego kursu nie jest nabycie kompletnej wiedzy, ale umożliwienie Ci w ciągu kilku godzin zrozumienia podstawowych pojęć HTML, CSS, JavaScript i Jquery. Zamiast pokazywać wiele slajdów, skupimy się w większości na praktycznych przykładach. Przejdziemy przez prosty przykład strony internetowej i pokażemy, jak zbudować HTML, zmienić sposób, w jaki on wygląda za pomocą CSS, a następnie w końcu napisać kod do rzeczywistej interakcji z użytkownikiem oraz z żądaniami sieciowymi za pomocą JavaScriptu. Dzięki poznaniu podstaw i ich wspólnej pracy możesz zacząć szybko działać. Podczas tego kursu zapoznam Cię z podstawami tworzenia stron WWW po stronie klienta, pokazując podstawy budowania stron internetowych za pomocą HTML, CSS, JavaScript i jQuery.",
                },
                CourseContent = new List<Content>
                {
                    new Content
                    {
                        ContentId = 9,
                        Chapters = new List<Chapter>
                        {
                            new Chapter
                            {
                                ChapterId = 65,
                                Name = "HTML",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 564,
                                        Name = "Wprowadzenie",
                                        Duration = "00:05:12"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 565,
                                        Name = "Co To Jest HTML",
                                        Duration = "00:10:32"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 566,
                                        Name = "Znaczniki HTML",
                                        Duration = "00:20:13"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 567,
                                        Name = "Struktura Strony Html5",
                                        Duration = "00:26:37"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 568,
                                        Name = "Emmet",
                                        Duration = "00:05:12"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 569,
                                        Name = "Tagi",
                                        Duration = "00:10:32"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 570,
                                        Name = "Formularze",
                                        Duration = "00:10:32"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 571,
                                        Name = "Nowe Pola Formularza",
                                        Duration = "00:10:32"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 572,
                                        Name = "Cross Browser HTML",
                                        Duration = "00:10:32"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 573,
                                        Name = "Podsumowanie",
                                        Duration = "00:26:37"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 66,
                                Name = "Css Stylizacja HTMLa",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 574,
                                        Name = "Wprowadzenie",
                                        Duration = "00:26:04"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 575,
                                        Name = "Stylizacja HTMLa",
                                        Duration = "00:38:43"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 576,
                                        Name = "Tag Style",
                                        Duration = "00:25:34"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 577,
                                        Name = "Wprowadzenie CSS",
                                        Duration = "00:23:04"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 578,
                                        Name = "ID Selektory",
                                        Duration = "00:24:54"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 579,
                                        Name = "Selektory Względne",
                                        Duration = "00:24:54"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 580,
                                        Name = "Selektory – Klas",
                                        Duration = "00:24:54"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 581,
                                        Name = "Rozmiar I Model Pudełkowy",
                                        Duration = "00:24:54"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 582,
                                        Name = "Pozycjonowanie W CSS",
                                        Duration = "00:24:54"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 583,
                                        Name = "Wyświetlanie w CSS",
                                        Duration = "00:24:54"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 584,
                                        Name = "Float W CSS",
                                        Duration = "00:24:54"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 585,
                                        Name = "Debugowanie Styli W Przeglądarce",
                                        Duration = "00:24:54"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 586,
                                        Name = "Podsumowanie",
                                        Duration = "00:20:09"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 67,
                                Name = "JavaScript",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 587,
                                        Name = "Wprowadzenie",
                                        Duration = "00:17:45"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 588,
                                        Name = "Co To Jest JavaScript",
                                        Duration = "00:19:31"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 589,
                                        Name = "Witaj JavaScript",
                                        Duration = "00:37:12"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 590,
                                        Name = "Dołączanie JavaScriptu Do Strony HTML",
                                        Duration = "00:23:58"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 591,
                                        Name = "Zmienne I Typy",
                                        Duration = "00:27:28"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 592,
                                        Name = "Waruki",
                                        Duration = "00:30:23"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 593,
                                        Name = "Funkcje",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 594,
                                        Name = "Zakresy (Scopes)",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 595,
                                        Name = "Zamknięcia (Closures)",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 596,
                                        Name = "Obiekty I Tablice",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 597,
                                        Name = "Pętle",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 598,
                                        Name = "Podsumowanie",
                                        Duration = "00:21:33"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 68,
                                Name = "jQuery",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 599,
                                        Name = "Wprowadzenie",
                                        Duration = "00:35:44"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 600,
                                        Name = "Co To Jest jQuery",
                                        Duration = "00:24:43"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 601,
                                        Name = "Podstawy jQuery",
                                        Duration = "00:19:39"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 602,
                                        Name = "Obsługa Zdarzeń W jQuery",
                                        Duration = "00:21:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 603,
                                        Name = "Zapytania Za Pomocą jQuery",
                                        Duration = "00:21:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 604,
                                        Name = "Modyfikowanie Strony Z jQuery",
                                        Duration = "00:21:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 605,
                                        Name = "Żądania Sieciowe Z jQuery",
                                        Duration = "00:21:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 606,
                                        Name = "Praca Z Formularzami Z jQuery",
                                        Duration = "00:21:50"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 607,
                                        Name = "Podsumowanie",
                                        Duration = "00:21:50"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 69,
                                Name = "Z Całkiem Innej Beczki",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 608,
                                        Name = "Canva",
                                        Duration = "00:16:11"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 609,
                                        Name = "Nozbe",
                                        Duration = "00:18:28"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 610,
                                        Name = "Evernote",
                                        Duration = "00:12:26"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 611,
                                        Name = "Generator Kalendarzy",
                                        Duration = "00:06:58"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 612,
                                        Name = "Smash i WeTransfer",
                                        Duration = "00:09:13"
                                    }
                                }
                            }
                        }
                    }
                },
                Faq = new List<Faq>
                {
                    new Faq
                    {
                        FaqId = 23,
                        Question = "Pytanie 1",
                        Answer = "Odpowiedz na pierwszr czesto zadawane pytanie"
                    }
                },
                Announcements = new List<Announcement>
                {
                    new Announcement
                    {
                        AnnouncementId = 14,
                        Content = "Kod źródłowy dostępny na githubie : https://github.com/mariuszjurczenko/HtmlCssJS"
                    }
                },
                Opinions = new List<Opinion>
                {
                    new Opinion
                    {
                        OpinionId = 12,
                        Content = "Polecam dobry kurs prowadzony spokojnie a nawet humorystycznie",
                        NumberOfStars = 5
                    }
                },
                Category = _categoryRepository.AllCategories.ToList()[5]
            },
            new Course
            {
                CourseId = 10,
                Name = "Portal Randkowy – Seria Web Developer – część 3",
                Author = "Mariusz Jurczenko",
                Price = 100,
                ImageUrl = "https://dev-hobby.pl/wordpress/wp-content/uploads/2020/09/Web-Developer-Portal-Randkowy.png",
                ImageThumbnailUrl = "https://dev-hobby.pl/wordpress/wp-content/uploads/2020/09/Web-Developer-Portal-Randkowy-300x169.png",
                IsCourseOfTheMonth = true,
                IsRecommended = true,
                Description = new Description
                {
                    DescriptionId = 10,
                    Name= "Budowanie aplikacji ASP.NET Core 2.2 Web API z wykorzystaniem Angular 8",
                    WhatWillYouLearn = new List<WhatWillYouLearn>
                    {
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 67,
                            Content = "Dowiesz się, jak zbudować aplikację internetową od początku do publikacji."
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 68,
                            Content = "Zdobędziesz praktyczną wiedzę na temat ASPNET Core, Entity Framework Core i Angular (v8)."
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 69,
                            Content = "Dowiesz się, jak wdrożyć system przesyłania wiadomości."
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 70,
                            Content = "Dowiesz się, jak zaimplementować uwierzytelnianie za pomocą tokenów JWT."
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 71,
                            Content = "Dowiesz się, jak zorganizować aplikację Angular przy użyciu najlepszych praktyk."
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 72,
                            Content = "I wiele więcej..."
                        }
                    },
                    Requirements = new List<Requirement>
                    {
                        new Requirement
                        {
                            RequirementId = 18,
                            Content = "Pasja i chęci nauczenia się, jak zbudować w pełni funkcjonalną aplikację internetową."
                        }
                    },
                    WhoIsThisCourseFor = new List<WhoIsThisCourseFor>
                    {
                        new WhoIsThisCourseFor
                        {
                            WhoIsThisCourseForId = 38,
                            Content = "Początkujący w ASPNET Core i Angular."
                        },
                        new WhoIsThisCourseFor
                        {
                            WhoIsThisCourseForId = 39,
                            Content = "Wszyscy którzy chcą zbudować atrakcyjną i funkcjonalną aplikację."
                        },
                        new WhoIsThisCourseFor
                        {
                            WhoIsThisCourseForId = 40,
                            Content = "Wszyscy którzy lubią się uczyć przez praktykę!!!"
                        }
                    },
                    Content = "W tym kursie będziemy budować jeden duży praktyczny projekt “Portal Randkowy”. Będziemy go budować od początku do końca łącznie z opublikowaniem w sieci, gdzie będzie można go przetestować!!! Może nawet znaleźć swoją drugą połówkę! Ten kurs jest bardzo praktyczny, lekcje będą wymagały kodowania !!! Jeśli jesteś typem osoby, która lubi uczyć się przez praktykę, to ten kurs jest zdecydowanie dla Ciebie !!! Wszystko, czego potrzebujesz, aby rozpocząć, to komputer z twoim ulubionym systemem operacyjnym i pasja do nauki tworzenia aplikacji przy użyciu ASP.NET Core i Angular.",
                },
                CourseContent = new List<Content>
                {
                    new Content
                    {
                        ContentId = 10,
                        Chapters = new List<Chapter>
                        {
                            new Chapter
                            {
                                ChapterId = 70,
                                Name = "Rozpoczęcie Projektu Portal Randkowy",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 613,
                                        Name = "Przygotowanie Do Rozpoczęcia Projektu",
                                        Duration = "00:05:12"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 614,
                                        Name = "Utworzenie Projektu Portal Randkowy Web API",
                                        Duration = "00:10:32"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 615,
                                        Name = "Przeglądanie Plików Startowych Projektu Web API",
                                        Duration = "00:20:13"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 616,
                                        Name = "Uruchomienie Projektu Web API",
                                        Duration = "00:26:37"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 617,
                                        Name = "Utworzenie Pierwszego Modelu",
                                        Duration = "00:05:12"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 618,
                                        Name = "Utworzenie Bazy Danych",
                                        Duration = "00:10:32"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 619,
                                        Name = "Pobieranie Danych Z Bazy Danych",
                                        Duration = "00:10:32"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 620,
                                        Name = "Przechodzimy Na Kod Asynchroniczny",
                                        Duration = "00:10:32"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 621,
                                        Name = "Utworzenie Aplikacji SPA Z Angular 8",
                                        Duration = "00:10:32"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 622,
                                        Name = "Uruchomienie Aplikacji Angular",
                                        Duration = "00:26:37"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 623,
                                        Name = "Wykonywanie Żądań HTTP W Angular",
                                        Duration = "00:26:37"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 624,
                                        Name = "Wyświetlanie Danych Na Stronie Z API",
                                        Duration = "00:26:37"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 625,
                                        Name = "Dodanie Bootstrap I Fontawesome Do Naszej Aplikacji",
                                        Duration = "00:26:37"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 71,
                                Name = "Zabezpieczenie Aplikacji",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 626,
                                        Name = "Wprowadzenie",
                                        Duration = "00:26:04"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 627,
                                        Name = "Utworzenie Klasy Użytkownik",
                                        Duration = "00:38:43"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 628,
                                        Name = "Utworzenie Interfejsu Do Autoryzacji",
                                        Duration = "00:25:34"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 629,
                                        Name = "Utworzenie Repozytorium Do Autoryzacji",
                                        Duration = "00:23:04"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 630,
                                        Name = "Dodanie Metody Logowania Użytkownika",
                                        Duration = "00:24:54"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 631,
                                        Name = "Dodanie Kontrolera Do Autoryzacji",
                                        Duration = "00:24:54"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 632,
                                        Name = "Utworzenie DTO",
                                        Duration = "00:24:54"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 633,
                                        Name = "Walidacja",
                                        Duration = "00:24:54"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 634,
                                        Name = "Kontroler dodanie Metody Logowania",
                                        Duration = "00:24:54"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 635,
                                        Name = "Użycie Uwierzytelniania",
                                        Duration = "00:24:54"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 636,
                                        Name = "Utworzenie Komponentu Nawigacyjnego",
                                        Duration = "00:24:54"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 637,
                                        Name = "Formularz Logowania",
                                        Duration = "00:24:54"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 638,
                                        Name = "Utworzenie Naszej Pierwszej Usługi",
                                        Duration = "00:20:09"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 639,
                                        Name = "Użycie Naszej Usługi W Komponencie",
                                        Duration = "00:24:54"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 640,
                                        Name = "Warunkowe Wyświetlanie Elementu Na Stronie",
                                        Duration = "00:24:54"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 641,
                                        Name = "Dodajemy Komponent Rejestracji Użytkownika",
                                        Duration = "00:24:54"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 642,
                                        Name = "Komunikacja Komponentów Od Rodzica Do Dziecka",
                                        Duration = "00:24:54"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 643,
                                        Name = "Komunikacja Komponentów Od Dziecka Do Rodzica",
                                        Duration = "00:20:09"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 644,
                                        Name = "Dodajemy Metodę Rejestracji Użytkowników",
                                        Duration = "00:24:54"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 645,
                                        Name = "Wyświetlanie Powiadomień Dla Użytkownika",
                                        Duration = "00:24:54"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 646,
                                        Name = "Dodanie Biblioteki Angular-jwt",
                                        Duration = "00:24:54"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 647,
                                        Name = "Rozkodowanie Tokena",
                                        Duration = "00:20:09"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 72,
                                Name = "Portal Randkowy",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 648,
                                        Name = "Rozszerzamy Klasę Użytkownik",
                                        Duration = "00:17:45"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 649,
                                        Name = "Dodanie Migracji Uaktualnienie Bazy Danych",
                                        Duration = "00:19:31"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 650,
                                        Name = "Dane Testowe",
                                        Duration = "00:37:12"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 651,
                                        Name = "Ładowanie Danych Testowych do Bazy Danych",
                                        Duration = "00:23:58"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 652,
                                        Name = "Dodanie GenericRepository I UserRepository",
                                        Duration = "00:27:28"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 653,
                                        Name = "Dodanie UserController",
                                        Duration = "00:30:23"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 654,
                                        Name = "Dodanie Dto",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 655,
                                        Name = "AutoMapper",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 656,
                                        Name = "AutoMapper Mapowanie",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 657,
                                        Name = "Dodajemy Model Do Naszej Aplikacji SPA",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 658,
                                        Name = "Dodajemy User Service",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 659,
                                        Name = "Dodajemy Component User List",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 660,
                                        Name = "Dodanie Routingu",
                                        Duration = "00:37:12"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 661,
                                        Name = "Ustawiamy Linki Nawigacyjne",
                                        Duration = "00:23:58"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 662,
                                        Name = "Przekierowanie Do Wybranej Strony",
                                        Duration = "00:27:28"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 663,
                                        Name = "Zabezpieczenie Routingu",
                                        Duration = "00:30:23"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 664,
                                        Name = "Zabezpieczenie Routingu cz.2",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 665,
                                        Name = "Dodanie Ngx Bootstrap",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 666,
                                        Name = "Dodanie Bootswatch",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 667,
                                        Name = "Obsługa Błędów W API",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 668,
                                        Name = "Obsługa Błędów W API cz.2",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 669,
                                        Name = "Obsługa Błędów Angular",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 670,
                                        Name = "Dodanie Komponentu Karta Użytkownika",
                                        Duration = "00:37:12"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 671,
                                        Name = "Dodajemy Przyciski Do Karty Użytkownika",
                                        Duration = "00:23:58"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 672,
                                        Name = "Dodajemy Banery Reklamowe",
                                        Duration = "00:27:28"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 673,
                                        Name = "Dodanie Komponentu Szczegóły Użytkownika",
                                        Duration = "00:30:23"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 674,
                                        Name = "Szczegóły Użytkownika Szablon",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 675,
                                        Name = "Szczegóły Użytkownika Zakładki",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 676,
                                        Name = "Szczegóły Użytkownika Zakładki Stylowanie",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 677,
                                        Name = "Route Resolvers",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 678,
                                        Name = "Galeria Zdjęć",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 679,
                                        Name = "Edycja Użytkownika Dodanie Komponentu",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 680,
                                        Name = "Edycja Użytkownika Przygotowanie Szablonu",
                                        Duration = "00:37:12"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 681,
                                        Name = "Edycja Użytkownika Modyfikujemy Szablon",
                                        Duration = "00:23:58"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 682,
                                        Name = "Edycja Użytkownika Zapobiegamy Utracie Nie Zapisanych Danych",
                                        Duration = "00:27:28"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 683,
                                        Name = "Edycja Użytkownika API",
                                        Duration = "00:30:23"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 684,
                                        Name = "Edycja Użytkownika Wykorzystanie API",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 685,
                                        Name = "Claudinary Konfiguracja.",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 686,
                                        Name = "Dodajemy Kontroler Zdjęć",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 687,
                                        Name = "Kontroler Zdjęć Modyfikacje",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 688,
                                        Name = "Testujemy Dodawanie Zdjęcia W Postmanie",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 689,
                                        Name = "Angular Dodajemy Komponent Zdjęcia",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 690,
                                        Name = "Dodanie Zewnętrznengo Komponentu Do Przesyłania Plików",
                                        Duration = "00:37:12"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 691,
                                        Name = "Konfiguracja Stylizacja Komponentu Do Zdjęć",
                                        Duration = "00:23:58"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 692,
                                        Name = "Ustawiamy Zdjęcie Główne API",
                                        Duration = "00:27:28"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 693,
                                        Name = "Ustawiamy Zdjęcie Główne SPA",
                                        Duration = "00:30:23"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 694,
                                        Name = "Ustawiamy Zdjęcie Główne Dodajemy Właściwość @Output",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 695,
                                        Name = "Dodajemy Zdjecie Główne Do Nawigacji",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 696,
                                        Name = "Użycie BehaviorSubject",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 697,
                                        Name = "Usuwanie Zdjęcia API",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 698,
                                        Name = "Usuwanie Zdjęcia SPA",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 699,
                                        Name = "Reactive Forms",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 700,
                                        Name = "Walidacja",
                                        Duration = "00:37:12"
                                    },
                                    new Lesson
                                    {
                                        LessonId =  701,
                                        Name = "Dodajemy Nasz Własny Walidator",
                                        Duration = "00:23:58"
                                    },
                                    new Lesson
                                    {
                                        LessonId =  702,
                                        Name = "Wyświetlanie Komunikatów Walidacyjnych Użytkownikowi",
                                        Duration = "00:27:28"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 703,
                                        Name = "FromBuilder Service",
                                        Duration = "00:30:23"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 704,
                                        Name = "Dodajemy Dodatkowe Pola Do Formularza",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 705,
                                        Name = "Użycie Datepicker",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 706,
                                        Name = "Uaktualnienie Metody Rejestracji W API",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 707,
                                        Name = "Dokończenie Rejestracji W Naszej Aplikacji SPA",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 708,
                                        Name = "Poprawki Z Domyślnym Zdjęciem Użytkownika",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 709,
                                        Name = "Wyświetlanie Daty",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 710,
                                        Name = "Ostatnia Aktywność Action Filtr",
                                        Duration = "00:37:12"
                                    },
                                    new Lesson
                                    {
                                        LessonId =  711,
                                        Name = "Stronnicowanie Dodanie PagedList",
                                        Duration = "00:23:58"
                                    },
                                    new Lesson
                                    {
                                        LessonId =  712,
                                        Name = "Stronnicowanie Pagination Helper",
                                        Duration = "00:27:28"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 713,
                                        Name = "Stronnicowanie Implementacja W API",
                                        Duration = "00:30:23"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 714,
                                        Name = "Stronnicowanie Ngx Bootstrap Pagination",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 715,
                                        Name = "API Filtrowanie",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 716,
                                        Name = "SPA Filtrowanie",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 717,
                                        Name = "API Sortowanie",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 718,
                                        Name = "SPA Sortowanie",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 719,
                                        Name = "Dodanie Klasy Like",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 720,
                                        Name = "Dodanie Funkcjonalności Polubień Do API",
                                        Duration = "00:37:12"
                                    },
                                    new Lesson
                                    {
                                        LessonId =  721,
                                        Name = "Pobieranie Listy Użytkowników Lubiących I Lubianych Przez Użytkownika",
                                        Duration = "00:23:58"
                                    },
                                    new Lesson
                                    {
                                        LessonId =  722,
                                        Name = "Dodanie Funkcjonalnosci Polubień Do SPA",
                                        Duration = "00:27:28"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 723,
                                        Name = "Implementacja Komponentu Polubienia SPA",
                                        Duration = "00:30:23"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 724,
                                        Name = "Dodajemy Klase Wiadomości",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 725,
                                        Name = "Dodanie Metod Do Repozytorium Dla Wiadomości",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 726,
                                        Name = "Dodanie Kontrolera Wiadomości",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 727,
                                        Name = "Implementacja Metody W Repozytorium Dla Skrzynki Nadawczej I Odbiorczej",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 728,
                                        Name = "Implementacja Metody GetMessagesForUser W Kontrolerze",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 729,
                                        Name = "Pobieranie Konwersacji 2 Użytkowników",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 730,
                                        Name = "Message Component",
                                        Duration = "00:37:12"
                                    },
                                    new Lesson
                                    {
                                        LessonId =  731,
                                        Name = "Message Component Szablon",
                                        Duration = "00:23:58"
                                    },
                                    new Lesson
                                    {
                                        LessonId =  732,
                                        Name = "User Messages Component",
                                        Duration = "00:27:28"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 733,
                                        Name = "User Messages Component Wygląd",
                                        Duration = "00:30:23"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 734,
                                        Name = "Messages Query Params",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 735,
                                        Name = "Wysyłanie Wiadomości",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 736,
                                        Name = "Rozwiazanie Problemu",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 737,
                                        Name = "Usuwanie Wiadomości API",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 738,
                                        Name = "Usuwanie Wiadomości SPA",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 739,
                                        Name = "Poprawka Wiadomosci",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 740,
                                        Name = "Przeczytana Wiadomosc",
                                        Duration = "00:37:12"
                                    },
                                    new Lesson
                                    {
                                        LessonId =  741,
                                        Name = "Poprawka Rejestracja Polubienia",
                                        Duration = "00:23:58"
                                    },
                                    new Lesson
                                    {
                                        LessonId =  742,
                                        Name = "Poprawka Polubienia",
                                        Duration = "00:27:28"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 743,
                                        Name = "Ng build",
                                        Duration = "00:30:23"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 744,
                                        Name = "Ng build –prod",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 745,
                                        Name = "Instalacja MySql",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 746,
                                        Name = "Dodanie Dostawcy Do MySql",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 747,
                                        Name = "Przechodzimy Na Baze MySql",
                                        Duration = "00:21:33"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 748,
                                        Name = "Publikujemy Strone Na IIS",
                                        Duration = "00:21:33"
                                    }
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 73,
                                Name = "Z Całkiem Innej Beczki",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 749,
                                        Name = "Canva",
                                        Duration = "00:16:11"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 750,
                                        Name = "Nozbe",
                                        Duration = "00:18:28"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 751,
                                        Name = "Evernote",
                                        Duration = "00:12:26"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 752,
                                        Name = "Generator Kalendarzy",
                                        Duration = "00:06:58"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 753,
                                        Name = "Smash i WeTransfer",
                                        Duration = "00:09:13"
                                    }
                                }
                            }
                        }
                    }
                },
                Faq = new List<Faq>
                {
                    new Faq
                    {
                        FaqId = 24,
                        Question = "Często zadawane pytanie",
                        Answer = "Odpowiedz na pierwszr czesto zadawane pytanie"
                    }
                },
                Announcements = new List<Announcement>
                {
                    new Announcement
                    {
                        AnnouncementId = 15,
                        Content = "Kod źródłowy dostępny na githubie : https://github.com/mariuszjurczenko/PortalRandkowy"
                    }
                },
                Opinions = new List<Opinion>
                {
                    new Opinion
                    {
                        OpinionId = 13,
                        Content = "Bardzo ciekawy kurs. Zwięźle i rzeczowo. Poza niezaprzeczalną dawką wiedzy, można znaleźć w nim również całkiem sporo motywacji do działania :) Polecam",
                        NumberOfStars = 5
                    },
                    new Opinion
                    {
                        OpinionId = 14,
                        Content = "Kurs dobry zwykle poszczególne kroki są przystępnie wytłumaczone. Ogólnie polecam z odrobiną wysiłku udało mi się skończyć projekt w .Net Core 3.1 oraz Angular 8",
                        NumberOfStars = 5
                    },
                },
                Category = _categoryRepository.AllCategories.ToList()[4]
            },
            new Course
            {
                CourseId = 11,
                Name = "Asp.Net MVC Praktyczny Kurs",
                Author = "Mariusz Jurczenko",
                Price = 100,
                ImageUrl = "https://dev-hobby.pl/wordpress/wp-content/uploads/2020/09/Sklep-Internetowy.png",
                ImageThumbnailUrl = "https://dev-hobby.pl/wordpress/wp-content/uploads/2020/09/Sklep-Internetowy-300x169.png",
                IsCourseOfTheMonth = false,
                IsRecommended = false,
                Description = new Description
                {
                    DescriptionId = 11,
                    Name= "Asp.Net MVC Praktyczny Kurs – Aplikacja Sklepu Internetowego",
                    WhatWillYouLearn = new List<WhatWillYouLearn>
                    {
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 73,
                            Content = "ASP NET MVC"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 74,
                            Content = "Entity Framework i podejście code first"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 75,
                            Content = "Inicjalizowania bazy danych"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 76,
                            Content = "Mechanizm migracji"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 77,
                            Content = "Glimps"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 78,
                            Content = "Cache"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 78,
                            Content = "Wywołań asynchronicznych AJAX"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 80,
                            Content = "Logowania i rejestracji użytkowników"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 81,
                            Content = "Mechanizm koszyka"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 82,
                            Content = "Elmach i Nlog"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 83,
                            Content = "Postal"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 84,
                            Content = "Hangfire"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 85,
                            Content = "Kontener DI (Dependency Injection)"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 86,
                            Content = "LocalDb"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 86,
                            Content = "Wersjonowania kodu Git"
                        },
                        new WhatWillYouLearn
                        {
                            WhatWillYouLearnId = 88,
                            Content = "Zarządzania projektem VisualStudio Online"
                        }
                    },
                    Requirements = new List<Requirement>
                    {
                        new Requirement
                        {
                            RequirementId = 19,
                            Content = "Podstawowa znajomość C#"
                        }
                    },
                    WhoIsThisCourseFor = new List<WhoIsThisCourseFor>
                    {
                        new WhoIsThisCourseFor
                        {
                            WhoIsThisCourseForId = 41,
                            Content = "Początkujący programiści ASP NET MVC"
                        },
                        new WhoIsThisCourseFor
                        {
                            WhoIsThisCourseForId = 42,
                            Content = "Początkujący programiści C#"
                        },
                        new WhoIsThisCourseFor
                        {
                            WhoIsThisCourseForId = 43,
                            Content = "Wszyscy chętni do dobrej zabawy z kodowaniem"
                        }
                    },
                    Content = "Pokażę praktyczne zastosowanie technologii ASP.NET MVC. Zbuduję w pełni funkcjonalny sklep internetowy. W kursie będziemy korzystać z Visual Studio Comunity oraz wbudowanej bazy danych localDb. Skorzystamy również z systemu do wersjonowania kodu i zarządzania projektem VisualStudio Online, będziemy korzystać z Gita. Następnie dodamy Makietę – prototyp aplikacji do naszego projektu, wyodrębnimy części wspólne widoków do tzw. layoutu. Dodamy strony statyczne do naszej aplikacji. Dodamy trasy dla stron statycznych. Zainstalujemy Glimpsa. Oprogramujemy stronę główną naszej aplikacji, oprogramujemy stronę z kursami w wybranej kategorii, zrobimy widok pojedynczego kursu. Dodamy scieżkę nawigacyjną, dodamy Cache, pokażę jak zrealizować mechanizm filtrowania kursów oraz autopodpowiedzi przy użyciu javaScriptu i wywołań  asynchronicznych AJAX, oraz wykorzystamy JSONa. Zaimplementujemy mechanizm koszyka. Zrobimy widoki logowania i rejestracji użytkowników. Te 2 widoki będą oparte o bardzo podobna strukturę do widoku koszyka na zakupy który już zrobiliśmy. Do naszych widoków rejestracja użytkowników i logowanie użytkowników dodamy mechanizmy obsługujące logikę rejestracji  użytkowników i logowania użytkowników, i skorzystamy tutaj z gotowych wbudowanych mechanizmów w ASP dot net MVC takich jak  ASPNET identity.",
                },
                CourseContent = new List<Content>
                {
                    new Content
                    {
                        ContentId = 11,
                        Chapters = new List<Chapter>
                        {
                            new Chapter
                            {
                                ChapterId = 74,
                                Name = "Aplikacja Sklepu Internetowego",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 754,
                                        Name = "Lekcja 1",
                                        Duration = "00:05:12"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 755,
                                        Name = "Lekcja 2",
                                        Duration = "00:10:32"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 756,
                                        Name = "Lekcja 3",
                                        Duration = "00:20:13"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 757,
                                        Name = "Lekcja 4",
                                        Duration = "00:26:37"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 758,
                                        Name = "Lekcja 5",
                                        Duration = "00:05:12"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 759,
                                        Name = "Lekcja 6",
                                        Duration = "00:10:32"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 760,
                                        Name = "Lekcja 7",
                                        Duration = "00:10:32"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 761,
                                        Name = "Lekcja 8",
                                        Duration = "00:10:32"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 762,
                                        Name = "Lekcja 9",
                                        Duration = "00:10:32"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 763,
                                        Name = "Lekcja 10",
                                        Duration = "00:26:37"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 764,
                                        Name = "Lekcja 11",
                                        Duration = "00:26:37"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 765,
                                        Name = "Lekcja 12",
                                        Duration = "00:26:37"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 766,
                                        Name = "Lekcja 13",
                                        Duration = "00:26:37"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 767,
                                        Name = "Lekcja 14",
                                        Duration = "00:26:37"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 768,
                                        Name = "Lekcja 15",
                                        Duration = "00:05:12"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 769,
                                        Name = "Lekcja 16",
                                        Duration = "00:10:32"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 770,
                                        Name = "Lekcja 17",
                                        Duration = "00:10:32"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 771,
                                        Name = "Lekcja 18",
                                        Duration = "00:10:32"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 772,
                                        Name = "Lekcja 19",
                                        Duration = "00:10:32"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 773,
                                        Name = "Lekcja 20",
                                        Duration = "00:26:37"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 774,
                                        Name = "Lekcja 21",
                                        Duration = "00:26:37"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 775,
                                        Name = "Lekcja 22",
                                        Duration = "00:26:37"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 776,
                                        Name = "Lekcja 23",
                                        Duration = "00:26:37"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 777,
                                        Name = "Lekcja 24",
                                        Duration = "00:26:37"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 778,
                                        Name = "Lekcja 25",
                                        Duration = "00:05:12"
                                    },
                                }
                            },
                            new Chapter
                            {
                                ChapterId = 75,
                                Name = "Z Całkiem Innej Beczki",
                                Lessons = new List<Lesson>
                                {
                                    new Lesson
                                    {
                                        LessonId = 779,
                                        Name = "Canva",
                                        Duration = "00:16:11"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 780,
                                        Name = "Nozbe",
                                        Duration = "00:18:28"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 781,
                                        Name = "Evernote",
                                        Duration = "00:12:26"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 782,
                                        Name = "Generator Kalendarzy",
                                        Duration = "00:06:58"
                                    },
                                    new Lesson
                                    {
                                        LessonId = 783,
                                        Name = "Smash i WeTransfer",
                                        Duration = "00:09:13"
                                    }
                                }
                            }
                        }
                    }
                },
                Faq = new List<Faq>
                {
                    new Faq
                    {
                        FaqId = 25,
                        Question = "Pytanie 1",
                        Answer = "Odpowiedz na często zadawane pytanie"
                    }
                },
                Announcements = new List<Announcement>
                {
                    new Announcement
                    {
                        AnnouncementId = 16,
                        Content = "Kod źródłowy dostępny na githubie : https://github.com/mariuszjurczenko/SklepAspNetMvc"
                    }
                },
                Opinions = new List<Opinion>
                {
                    new Opinion
                    {
                        OpinionId = 15,
                        Content = "Bardzo ciekawy kurs. Zwięźle i rzeczowo. Polecam",
                        NumberOfStars = 5
                    }
                },
                Category = _categoryRepository.AllCategories.ToList()[4]
            },
        };

    public IEnumerable<Course> CourseOfTheMonth
        => AllCourses.Where(c => c.IsCourseOfTheMonth);

    public IEnumerable<Course> Recommended
        => AllCourses.Where(c => c.IsRecommended);

    public Course? GetCourseById(int courseId)
        => AllCourses.FirstOrDefault(c => c.CourseId == courseId);
}
