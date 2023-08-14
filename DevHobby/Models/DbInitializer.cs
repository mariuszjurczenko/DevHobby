using DevHobby.Models.Entities;

namespace DevHobby.Models;

public static class DbInitializer
{
    public static void Seed(IApplicationBuilder applicationBuilder)
    {
        DevHobbyDbContext devHobbyDbContext = applicationBuilder.ApplicationServices.CreateScope()
            .ServiceProvider.GetRequiredService<DevHobbyDbContext>();

        if (!devHobbyDbContext.Categories.Any())
        {
            devHobbyDbContext.Categories.AddRange(Categories.Select(c => c.Value));
        }

        if (!devHobbyDbContext.Courses.Any())
        {
            devHobbyDbContext.Courses.AddRange
            (
                new Course
                {
                    Name = "Angular – Od Zera Do Bohatera",
                    Author = "Mariusz Jurczenko",
                    Price = 100,
                    ImageUrl = "https://dev-hobby.pl/wordpress/wp-content/uploads/2020/09/Angular-Od-Zera-Do-Bohatera.png",
                    ImageThumbnailUrl = "https://dev-hobby.pl/wordpress/wp-content/uploads/2020/09/Angular-Od-Zera-Do-Bohatera-300x169.png",
                    IsCourseOfTheMonth = false,
                    IsRecommended = true,
                    Description = new Description
                    {
                        Name = "Wprowadzenie do Angular – Szybki start.",
                        WhatWillYouLearn = new List<WhatWillYouLearn>
                        {
                            new WhatWillYouLearn
                            {
                                Content = "Angular CLI"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Konfiguracja projektu"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "ES5, ES6, TypeScript"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Dependency Injection"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Propery binding"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Event binding"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Two-way binding"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Komponent, Moduł"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Get, Post, Delete, Patch"
                            },
                        },
                        Requirements = new List<Requirement>
                        {
                            new Requirement
                            {
                                Content ="Chęć dobrej zabawy !!!"
                            }
                        },
                        WhoIsThisCourseFor = new List<WhoIsThisCourseFor>
                        {
                            new WhoIsThisCourseFor
                            {
                                Content = "Każdy kto ma trochę chęci i trochę czasu"
                            }
                        },
                        Content = "Rozpoczęcie nowego projektu opartego o Angular wymaga stworzenia odpowiedniej struktury folderów, skonfigurowania środowiska, zainstalowania TypeScript, definicji typów, stworzenia pierwszego komponentu i wywołania funkcji bootstrap. Zacznijmy budowanie aplikacji od stworzenia potrzebnych komponentów przy pomocy Angular CLI. Dzięki pomocy Angular CLI, nie musimy już powtarzać wielu manualnych czynności co znacznie przyspiesza pracę z Angular.",
                    },
                    CourseContent = new List<Content>
                    {
                        new Content
                        {
                            Chapters = new List<Chapter>
                            {
                                new Chapter
                                {
                                    Name = "Pierwsza Aplikacja",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Lekcja 1",
                                            Duration = "00:14:36"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 2",
                                            Duration = "00:47:27"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Druga Aplikacja",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Lekcja 1",
                                            Duration = "00:21:25"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 2",
                                            Duration = "00:17:04"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 3",
                                            Duration = "00:23:40"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 4",
                                            Duration = "00:15:11"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 5",
                                            Duration = "00:14:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 6",
                                            Duration = "00:24:31"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 7",
                                            Duration = "00:13:58"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lek8ja 8",
                                            Duration = "00:17:13"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 9",
                                            Duration = "00:13:09"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 10",
                                            Duration = "00:22:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 11",
                                            Duration = "00:13:41"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 12",
                                            Duration = "00:23:05"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 13",
                                            Duration = "00:07:29"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 14",
                                            Duration = "00:10:26"
                                        }
                                    },
                                },
                                new Chapter
                                {
                                    Name = "Trzecia Aplikacja",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Lekcja 1",
                                            Duration = "00:15:28"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 2",
                                            Duration = "00:12:52"
                                        },
                                         new Lesson
                                        {
                                            Name = "Lekcja 3",
                                            Duration = "00:22:22"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 4",
                                            Duration = "00:17:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 5",
                                            Duration = "00:26:43"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 6",
                                            Duration = "00:20:17"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 7",
                                            Duration = "00:15:06"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lek8ja 8",
                                            Duration = "00:17:06"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 9",
                                            Duration = "00:29:34"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 10",
                                            Duration = "00:14:20"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja11",
                                            Duration = "00:12:03"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 12",
                                            Duration = "00:12:31"
                                        }
                                    },
                                },
                                new Chapter
                                {
                                    Name = "Http Promises Observables",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Http",
                                            Duration = "00:29:23"
                                        },
                                        new Lesson
                                        {
                                            Name = "Promises",
                                            Duration = "00:49:46"
                                        },
                                        new Lesson
                                        {
                                            Name = "Observables",
                                            Duration = "00:18:36"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Zakładki - Wykorzystanie Http...",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Lekcja 1",
                                            Duration = "00:15:31"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 2",
                                            Duration = "00:32:06"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 3",
                                            Duration = "00:30:10"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 4",
                                            Duration = "00:14:10"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 5",
                                            Duration = "00:19:32"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 6",
                                            Duration = "00:21:48"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Formularz",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Lekcja 1",
                                            Duration = "00:23:45"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 2",
                                            Duration = "00:23:37"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 3",
                                            Duration = "00:19:16"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 4",
                                            Duration = "00:14:41"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Z Całkiem Innej Beczki",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Canva",
                                            Duration = "00:16:11"
                                        },
                                        new Lesson
                                        {
                                            Name = "Nozbe",
                                            Duration = "00:18:28"
                                        },
                                        new Lesson
                                        {
                                            Name = "Evernote",
                                            Duration = "00:12:26"
                                        },
                                        new Lesson
                                        {
                                            Name = "Generator Kalendarzy",
                                            Duration = "00:06:58"
                                        },
                                        new Lesson
                                        {
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
                            Question = "Pytanie 1",
                            Answer = "Odpowiedz na pierwsze czesto zadawane pytanie."
                        },
                        new Faq
                        {
                            Question = "Pytanie 2",
                            Answer = "Odpowiedz na drugie czesto zadawane pytanie."
                        },
                        new Faq
                        {
                            Question = "Pytanie 3",
                            Answer = "Odpowiedz na trzecie czesto zadawane pytanie."
                        },
                        new Faq
                        {
                            Question = "Pytanie 4",
                            Answer = "Odpowiedz na czwarte czesto zadawane pytanie."
                        },
                        new Faq
                        {
                            Question = "Pytanie 5",
                            Answer = "Odpowiedz na piąte czesto zadawane pytanie."
                        }
                    },
                    Announcements = new List<Announcement>
                    {
                        new Announcement
                        {
                            Content = "Kod źródłowy dostępny na githubie : https://github.com/mariuszjurczenko/Angular2_AppFirst"
                        },
                        new Announcement
                        {
                            Content = "Kod źródłowy dostępny na githubie : https://github.com/mariuszjurczenko/Angular2_Converter"
                        },
                        new Announcement
                        {
                            Content = "Kod źródłowy dostępny na githubie : https://github.com/mariuszjurczenko/Angular2-formularz"
                        },
                        new Announcement
                        {
                            Content = "Kod źródłowy dostępny na githubie : https://github.com/mariuszjurczenko/Angular2-bookmarks2"
                        },
                        new Announcement
                        {
                            Content = "Kod źródłowy dostępny na githubie : https://github.com/mariuszjurczenko/Angular2-Http-odc29"
                        },
                        new Announcement
                        {
                            Content = "Kod źródłowy dostępny na githubie : https://github.com/mariuszjurczenko/Angular2-Http-odc30"
                        },
                    },
                    Opinions = new List<Opinion>
                    {
                        new Opinion
                        {
                            Content = "Bardzo ważny i przydatny kurs dla każdego. Kurs zawiera wiele cennych informacji na temat angulara. Polecam. :)",
                            NumberOfStars = 5
                        }
                    },
                    Category = Categories["ANGULAR"]
                },
                new Course
                {
                    Name = "Seria Programista C# – część 1 – Podstawy Programowania",
                    Author = "Mariusz Jurczenko",
                    Price = 100,
                    ImageUrl = "https://dev-hobby.pl/wordpress/wp-content/uploads/2020/09/Programista-C-Part1.png",
                    ImageThumbnailUrl = "https://dev-hobby.pl/wordpress/wp-content/uploads/2020/09/Programista-C-Part1-300x169.png",
                    IsCourseOfTheMonth = false,
                    IsRecommended = true,
                    Description = new Description
                    {
                        Name = "C# Podstawy programowania",
                        WhatWillYouLearn = new List<WhatWillYouLearn>
                        {
                            new WhatWillYouLearn
                            {
                                Content = "W krótkim czasie poznasz zupełnie od podstaw kompletny proces budowania aplikacji C#"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Zaczniesz programować pierwsze aplikacje"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Bedziesz tworzyć klasy i obiekty w swojm kodzie"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Zrozumiesz Delegaty i Zdarzenia"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Obsługi wyjątków"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Unikania często popełnianych błędów"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Wiele przydatnych wskazówek i dobrych praktyk"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Będziesz się dobrze bawić pisząc kod C#"
                            }
                        },
                        Requirements = new List<Requirement>
                        {
                            new Requirement
                            {
                                Content = "Chęć nauki programowania i dobrej zabawy !!!"
                            }
                        },
                        WhoIsThisCourseFor = new List<WhoIsThisCourseFor>
                        {
                            new WhoIsThisCourseFor
                            {
                                Content = "Początkujący programiści C#"
                            },
                            new WhoIsThisCourseFor
                            {
                                Content = "Chcesz w krótkim czasie poznać zupełnie od podstaw kompletny proces budowania aplikacji z C#?"
                            },
                            new WhoIsThisCourseFor
                            {
                                Content = "Chcesz opanować podstawy języka C#, zacznij programować pierwsze aplikacje jeszcze dziś!"
                            },
                            new WhoIsThisCourseFor
                            {
                                Content = "Chcesz tworzyć klasy i obiekty w C#?"
                            }
                        },
                        Content = "Szkolenie powstało z myślą o osobach początkujących, które chciałyby nauczyć się podstaw programowania w języku C# na praktycznych i prostych do zrozumienia przykładach. C# jak każdy język programowania ma mocne i słabe strony. Niektóre  języki są wydajne, lecz podatne na błędy lub trudne w stosowaniu, podczas gdy inne są prostsze, lecz mogą mieć ograniczoną funkcjonalność lub słabszą wydajność. C# jest językiem zaprojektowanym tak, aby stanowił optymalne połączenie prostoty, efektywności oraz użyteczności. W trakcie kursu będziesz budował proste aplikacje, co pozwoli Ci poznać dobrze różne obszary języka. Przyswoisz sobie wiele przydatnych wskazówek i dobrych praktyk, które pozwolą Ci zachować czytelność kodu i uniknąć najczęściej popełnianych błędów. Tworzenie klas to istota programowania.  To właśnie dlatego poświęciłem im cały rozdział. Dowiesz się z  niego między innymi jaką funkcję pełnią klasy w języku C#, jak je tworzyć oraz czym różnią się one od zmiennych. Poruszymy również bardzo  ważny temat hermetyzacji, modyfikatorów dostępu oraz budowy konstruktorów.",
                    },
                    CourseContent = new List<Content>
                    {
                        new Content
                        {
                            Chapters = new List<Chapter>
                            {
                                new Chapter
                                {
                                    Name = "Wstęp",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Wprowadzenie Do Kursu",
                                            Duration = "00:05:12"
                                        },
                                        new Lesson
                                        {
                                            Name = ".NET, CLR, FCL",
                                            Duration = "00:10:32"
                                        },
                                        new Lesson
                                        {
                                            Name = "Pierwszy Program",
                                            Duration = "00:20:13"
                                        },
                                        new Lesson
                                        {
                                            Name = "Pierwszy Program W Visual Studio",
                                            Duration = "00:26:37"
                                        },
                                        new Lesson
                                        {
                                            Name = "IDE",
                                            Duration = "00:22:38"
                                        },
                                        new Lesson
                                        {
                                            Name = "Zaczynamy Kodowanie :)",
                                            Duration = "00:38:49"
                                        },
                                        new Lesson
                                        {
                                            Name = "Quiz",
                                            Duration = "3 pytania"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Klasy I Obiekty",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Nasza Pierwsza Klasa",
                                            Duration = "00:26:04"
                                        },
                                        new Lesson
                                        {
                                            Name = "Tworzenie Obiektów",
                                            Duration = "00:38:43"
                                        },
                                        new Lesson
                                        {
                                            Name = "Konstruktor",
                                            Duration = "00:25:34"
                                        },
                                        new Lesson
                                        {
                                            Name = "Klasa A Zmienna",
                                            Duration = "00:23:04"
                                        },
                                        new Lesson
                                        {
                                            Name = "Programowania Obiektowe",
                                            Duration = "00:24:54"
                                        },
                                        new Lesson
                                        {
                                            Name = "Programowania Obiektowe cz.2",
                                            Duration = "00:22:53"
                                        },
                                        new Lesson
                                        {
                                            Name = "Hermetyzacja I Modyfikatory Dostępu",
                                            Duration = "00:20:09"
                                        },
                                        new Lesson
                                        {
                                            Name = "STATIC",
                                            Duration = "00:19:35"
                                        },
                                        new Lesson
                                        {
                                            Name = "Quiz",
                                            Duration = "3 pytania"
                                        }
                                    }
                                },
                                new Chapter
                                {

                                    Name = "Typy I Złożenia",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Typy Referencyjne",
                                            Duration = "00:17:45"
                                        },
                                        new Lesson
                                        {
                                            Name = "Typy Wartościowe",
                                            Duration = "00:19:31"
                                        },
                                        new Lesson
                                        {
                                            Name = "Parametry Metody",
                                            Duration = "00:37:12"
                                        },
                                        new Lesson
                                        {
                                            Name = "Struktury I Wyliczenia",
                                            Duration = "00:23:58"
                                        },
                                        new Lesson
                                        {
                                            Name = "Immutable",
                                            Duration = "00:27:28"
                                        },
                                        new Lesson
                                        {
                                            Name = "Tablice",
                                            Duration = "00:30:23"
                                        },
                                        new Lesson
                                        {
                                            Name = "Złożenia",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Unit Tests",
                                            Duration = "00:41:36"
                                        },
                                        new Lesson
                                        {
                                            Name = "Quiz",
                                            Duration = "4 pytania"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Członkowie Klasy",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Członkowie Klasy",
                                            Duration = "00:35:44"
                                        },
                                        new Lesson
                                        {
                                            Name = "Pola I Właściwości",
                                            Duration = "00:24:43"
                                        },
                                        new Lesson
                                        {
                                            Name = "Delegaty",
                                            Duration = "00:19:39"
                                        },
                                        new Lesson
                                        {
                                            Name = "Zdarzenia",
                                            Duration = "00:21:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Quiz",
                                            Duration = "4 pytania"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Kontrola Przepływu Aplikacji",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Rozgałęzienia Wykonania Kodu",
                                            Duration = "00:21:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Przelączanie",
                                            Duration = "00:13:08"
                                        },
                                        new Lesson
                                        {
                                            Name = "Pętle",
                                            Duration = "00:24:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Instrukcje Skoku",
                                            Duration = "00:17:59"
                                        },
                                        new Lesson
                                        {
                                            Name = "Throw",
                                            Duration = "00:14:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Try Catch",
                                            Duration = "00:22:47"
                                        },
                                        new Lesson
                                        {
                                            Name = "PFinally",
                                            Duration = "00:17:14"
                                        },
                                        new Lesson
                                        {
                                            Name = "Quiz",
                                            Duration = "4 pytania"
                                        },
                                        new Lesson
                                        {
                                            Name = "Podsumowanie Kursu",
                                            Duration = "00:01:58"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodatkowe materiały",
                                            Duration = ""
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Z Całkiem Innej Beczki",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Canva",
                                            Duration = "00:16:11"
                                        },
                                        new Lesson
                                        {
                                            Name = "Nozbe",
                                            Duration = "00:18:28"
                                        },
                                        new Lesson
                                        {
                                            Name = "Evernote",
                                            Duration = "00:12:26"
                                        },
                                        new Lesson
                                        {
                                            Name = "Generator Kalendarzy",
                                            Duration = "00:06:58"
                                        },
                                        new Lesson
                                        {
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
                            Question = "Jaka jest różnica pomiędzy klasą a obiektem?",
                            Answer = "Klasa jest definicją obiektu, a obiekt jest instancją klasy."
                        },
                        new Faq
                        {
                            Question = "Czy w języku C# można utworzyć metodę, która może przyjmować zmienną liczbę parametrów?",
                            Answer = "Tak, należy użyć słowa kluczowego params. Metoda taka może przyjąć zmienną liczbę parametrów."
                        },
                        new Faq
                        {
                            Question = "Co to są typy referencyjne?",
                            Answer = "Typy referencyjne nie przechowują rzeczywistych wartości a jedynie odniesienia(referencje) do zmiennych."
                        }
                    },
                    Announcements = new List<Announcement>
                    {
                        new Announcement
                        {
                            Content = "Kod źródłowy dostępny na githubie : https://github.com/mariuszjurczenko/CSarpKurs"
                        }
                    },
                    Opinions = new List<Opinion>
                    {
                        new Opinion
                        {
                            Content = "Bardzo dobrze przedstawione podstawy języka C#. Prowadzący przedstawia poszczególne elementy składni języka w przestępny sposób i na konkretnych przykładach. Lekcje bardzo dobrze przemyślane dzięki czemu możemy przećwiczyć poruszane w nich zagadnienia krok po kroku.",
                            NumberOfStars = 5
                        },
                        new Opinion
                        {
                            Content = "Dobry kurs podstaw języka C#. Trochę teorii i przykładów. Idealny na powtórzenie sobie materiału z języka C#. Dowiedziałem się kilku nowych rzeczy na które wcześniej nie zwróciłem uwagi takich jak przydatne skróty klawiszowe do szybszego pisania kodu, umieszczenie projektu na githubie, testy jednostkowe, delegaty i zdarzenia. Polecam.",
                            NumberOfStars = 5
                        },
                        new Opinion
                        {
                            Content = "Świetne wprowadzenie do programowania w C#. Szczególnie spodobało mi się, że kurs jest bardzo dobrze przemyślany i zaplanowany. Wszystko jest wytłumaczone bardzo klarownie, przeszedłem przez ten kurs z przyjemnością i zaczynam cześć drugą ;)",
                            NumberOfStars = 5
                        },
                    },
                    Category = Categories["CSHARP"]
                },
                new Course
                {
                    Name = "CMS Shop Paypal – Praktyczny projekt",
                    Author = "Mariusz Jurczenko",
                    Price = 100,
                    ImageUrl = "https://dev-hobby.pl/wordpress/wp-content/uploads/2020/09/CMs-shop-paypal-870x440.png",
                    ImageThumbnailUrl = "https://dev-hobby.pl/wordpress/wp-content/uploads/2020/09/CMs-shop-paypal-300x169.png",
                    IsCourseOfTheMonth = true,
                    IsRecommended = true,
                    Description = new Description
                    {
                        Name = "CMSShop Praktyczny projekt w Asp.Net Mvc zintegrowany z systemem płatności Paypal.",
                        WhatWillYouLearn = new List<WhatWillYouLearn>
                        {
                            new WhatWillYouLearn
                            {
                                Content = "Stworzysz praktyczny projekt Cms i sklep w AspNet MVC zintegrowany z systemem płatności Paypal"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "W krótkim czasie poznasz zupełnie od podstaw kompletny proces budowania aplikacji ASP_NET MVC"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "W praktyce wykorzystasz swoją znajomość języka C#"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Zdobędziesz umiejętności, które zapewnią Ci szansę na wspaniałą karierę zawodową"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Opanujesz liczne pojęcia, koncepcje oraz techniki, których znajomość jest niezbędna podczas tworzenia nowoczesnych aplikacji"
                            }
                        },
                        Requirements = new List<Requirement>
                        {
                            new Requirement
                            {
                                Content = "Podstawowa znajomość C#"
                            },
                            new Requirement
                            {
                                Content = "Podstawowa znajomość AspNet Mvc"
                            },
                        },
                        WhoIsThisCourseFor = new List<WhoIsThisCourseFor>
                        {
                            new WhoIsThisCourseFor
                            {
                                Content = "Początkujący programiści AspNet Mvc"
                            },
                            new WhoIsThisCourseFor
                            {
                                Content = "CChcesz w krótkim czasie poznać zupełnie od podstaw kompletny proces budowania aplikacji z ASP_NET?"
                            },
                            new WhoIsThisCourseFor
                            {
                                Content = "Chcesz w praktyce wykorzystać swoją znajomość języka C# i zdobyć umiejętności, które zapewnią Ci szansę na wspaniałą karierę zawodową?"
                            },
                            new WhoIsThisCourseFor
                            {
                                Content = "Chcesz opanować liczne pojęcia, koncepcje oraz techniki, których znajomość jest niezbędna podczas tworzenia nowoczesnych aplikacji?"
                            }
                        },
                        Content = "Projekt ten łączy w sobie funkcjonalność CMSa – systemu do zarządzania  treścią oraz funkcjonalność sklepu internetowego. Wszystko to jest  zrealizowane w jednym projekcie. Zawartość kursu mogła by być  wykorzystana w kilku osobnych kursach takich jak: asp.net mvc,  bootstrap, adminLte, cms, sklep. Całość stanowi jeden duży praktyczny  projekt, który musi być realizowany zgodnie z kolejnością nagranych  odcinków i który został podzielony na mniejsze moduły funkcjonalne.",
                    },
                    CourseContent = new List<Content>
                    {
                        new Content
                        {
                            Chapters = new List<Chapter>
                            {
                                new Chapter
                                {
                                    Name = "Rozpoczęcie Projektu Konfiguracja Administracja CMS",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Lekcja 1",
                                            Duration = "00:11:18"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 2",
                                            Duration = "00:09:04"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 3",
                                            Duration = "00:17:57"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 4",
                                            Duration = "00:15:11"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 5",
                                            Duration = "00:14:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 6",
                                            Duration = "00:24:31"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 7",
                                            Duration = "00:13:58"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lek8ja 8",
                                            Duration = "00:17:13"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 9",
                                            Duration = "00:13:09"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 10",
                                            Duration = "00:22:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 11",
                                            Duration = "00:13:41"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 12",
                                            Duration = "00:23:05"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 13",
                                            Duration = "00:07:29"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 14",
                                            Duration = "00:10:26"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 15",
                                            Duration = "00:22:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 16",
                                            Duration = "00:13:41"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 17",
                                            Duration = "00:23:05"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 18",
                                            Duration = "00:07:29"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 19",
                                            Duration = "00:10:26"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Administracja Sklep",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Lekcja 1",
                                            Duration = "00:11:18"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 2",
                                            Duration = "00:09:04"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 3",
                                            Duration = "00:17:57"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 4",
                                            Duration = "00:15:11"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 5",
                                            Duration = "00:14:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 6",
                                            Duration = "00:24:31"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 7",
                                            Duration = "00:13:58"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lek8ja 8",
                                            Duration = "00:17:13"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 9",
                                            Duration = "00:13:09"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 10",
                                            Duration = "00:22:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 11",
                                            Duration = "00:13:41"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 12",
                                            Duration = "00:23:05"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 13",
                                            Duration = "00:07:29"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 14",
                                            Duration = "00:10:26"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 15",
                                            Duration = "00:22:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 16",
                                            Duration = "00:13:41"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 17",
                                            Duration = "00:23:05"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 18",
                                            Duration = "00:07:29"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 19",
                                            Duration = "00:10:26"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 20",
                                            Duration = "00:13:41"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 21",
                                            Duration = "00:23:05"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 22",
                                            Duration = "00:07:29"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 23",
                                            Duration = "00:10:26"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 24",
                                            Duration = "00:23:05"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 25",
                                            Duration = "00:07:29"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 26",
                                            Duration = "00:10:26"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 27",
                                            Duration = "00:23:05"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 28",
                                            Duration = "00:07:29"
                                        },
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Front CMS Sklep",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Lekcja 1",
                                            Duration = "00:11:18"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 2",
                                            Duration = "00:09:04"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 3",
                                            Duration = "00:17:57"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 4",
                                            Duration = "00:15:11"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 5",
                                            Duration = "00:14:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 6",
                                            Duration = "00:24:31"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 7",
                                            Duration = "00:13:58"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Sklep Koszyk",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Lekcja 1",
                                            Duration = "00:11:18"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 2",
                                            Duration = "00:09:04"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 3",
                                            Duration = "00:17:57"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 4",
                                            Duration = "00:15:11"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 5",
                                            Duration = "00:14:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 6",
                                            Duration = "00:24:31"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 7",
                                            Duration = "00:13:58"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 8",
                                            Duration = "00:13:58"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Rejestracja Logowanie Role",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Lekcja 1",
                                            Duration = "00:11:18"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 2",
                                            Duration = "00:09:04"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 3",
                                            Duration = "00:17:57"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 4",
                                            Duration = "00:15:11"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 5",
                                            Duration = "00:14:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 6",
                                            Duration = "00:24:31"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 7",
                                            Duration = "00:13:58"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 8",
                                            Duration = "00:13:58"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 9",
                                            Duration = "00:13:58"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Rejestracja Logowanie Role",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Lekcja 1",
                                            Duration = "00:11:18"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 2",
                                            Duration = "00:09:04"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 3",
                                            Duration = "00:17:57"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 4",
                                            Duration = "00:15:11"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 5",
                                            Duration = "00:14:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 6",
                                            Duration = "00:24:31"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 7",
                                            Duration = "00:13:58"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 8",
                                            Duration = "00:13:58"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 9",
                                            Duration = "00:13:58"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 10",
                                            Duration = "00:13:58"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 11",
                                            Duration = "00:13:58"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 12",
                                            Duration = "00:13:58"
                                        },
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Z Całkiem Innej Beczki",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Canva",
                                            Duration = "00:16:11"
                                        },
                                        new Lesson
                                        {
                                            Name = "Nozbe",
                                            Duration = "00:18:28"
                                        },
                                        new Lesson
                                        {
                                            Name = "Evernote",
                                            Duration = "00:12:26"
                                        },
                                        new Lesson
                                        {
                                            Name = "Generator Kalendarzy",
                                            Duration = "00:06:58"
                                        },
                                        new Lesson
                                        {
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
                            Question = "Pytanie 1",
                            Answer = "Odpowiedz na pierwsze często zadawane pytanie"
                        }
                    },
                    Announcements = new List<Announcement>
                    {
                        new Announcement
                        {
                            Content = "Kod źródłowy dostępny na githubie : https://github.com/mariuszjurczenko/CmsShop"
                        }
                    },
                    Opinions = new List<Opinion>
                    {
                        new Opinion
                        {
                            Content = "Przykładowa opinia",
                            NumberOfStars = 5
                        }
                    },
                    Category = Categories["CMS"]
                },
                new Course
                {
                    Name = "Seria Programista C# – część 2 – Podstawy Programowanie Obiektowego",
                    Author = "Mariusz Jurczenko",
                    Price = 100,
                    ImageUrl = "https://dev-hobby.pl/wordpress/wp-content/uploads/2020/09/Programista-C-Part2.png",
                    ImageThumbnailUrl = "https://dev-hobby.pl/wordpress/wp-content/uploads/2020/09/Programista-C-Part2-300x169.png",
                    IsCourseOfTheMonth = false,
                    IsRecommended = true,
                    Description = new Description
                    {
                        Name = "Podstawy Programowanie obiektowego w języku C#",
                        WhatWillYouLearn = new List<WhatWillYouLearn>
                        {
                            new WhatWillYouLearn
                            {
                                Content = "Bedziesz tworzyć klasy i obiekty w swojm kodzie"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Będziesz analizował i identyfikował klas z wymagań biznesowych"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Bedziesz potrafił rozdzielać obowiązki klasy"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Nauczysz się rozpoznawać relacje między klasami "
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Zrozumiesz ideę ponownego użycia"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Nauczysz się budować komponenty"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Nauczysz się korzystać z interfejsów"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Opanujesz Ideą polimorfizmu"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "W krótkim czasie poznasz zupełnie od podstaw kompletny proces budowania aplikacji C#"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Unikania często popełnianych błędów#"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Wiele przydatnych wskazówek i dobrych praktyk"
                            }
                        },
                        Requirements = new List<Requirement>
                        {
                            new Requirement
                            {
                                Content = "Chęć nauki programowania i dobrej zabawy !!!"
                            },
                            new Requirement
                            {
                                Content = "C# Podstawy programowania"
                            },
                        },
                        WhoIsThisCourseFor = new List<WhoIsThisCourseFor>
                        {
                            new WhoIsThisCourseFor
                            {
                                Content = "Programiści C#"
                            },
                            new WhoIsThisCourseFor
                            {
                                Content = "Chcesz tworzyć klasy i obiekty w C#?"
                            },
                            new WhoIsThisCourseFor
                            {
                                Content = "Chcesz analizować i identyfikować klas z wymagań biznesowych?"
                            },
                            new WhoIsThisCourseFor
                            {
                                Content = "Chcesz potrafić rozdzielać obowiązki klasy?"
                            },
                            new WhoIsThisCourseFor
                            {
                                Content = "Chcesz nauczyć się rozpoznawać relacje między klasami?"
                            },
                            new WhoIsThisCourseFor
                            {
                                Content = "Chcesz zrozumieć ideę ponownego użycia?"
                            },
                            new WhoIsThisCourseFor
                            {
                                Content = "Chcesz nauczyć się budować komponenty?"
                            },
                            new WhoIsThisCourseFor
                            {
                                Content = "Chcesz nauczyć się korzystać z interfejsów?"
                            },
                            new WhoIsThisCourseFor
                            {
                                Content = "Chcesz opanować Ideą polimorfizmu?"
                            },
                            new WhoIsThisCourseFor
                            {
                                Content = "Chcesz w krótkim czasie poznać zupełnie od podstaw kompletny proces budowania aplikacji z C#?"
                            },
                        },
                        Content = "Tematem tego kursu będzie programowanie w języku C #, a dokładnie wszystko co powinieneś wiedzieć o programowaniu obiektowym. Po podaniu specyfikacji nowej funkcji lub nowej aplikacji zacznij od zidentyfikowania klas z wymagań lub specyfikacji. Programowanie obiektowe reprezentuje encje i koncepcje aplikacji jako zbioru klas. Następnym krokiem jest przeanalizowanie zidentyfikowanych klas i podział obowiązków w zależności od potrzeb. Chodzi o to, że aplikacja powinna zostać rozłożona na części z minimalnym nakładaniem się funkcji. Jeśli każda klasa ma jeden cel, łatwiej jest pisać, testować, a później znajdować tę klasę, gdy trzeba ją zaktualizować lub rozszerzyć. To sprawia, że kod jest łatwiejszy do modyfikacji i dostosowania do nowych wymagań i przyszłych wymagań. Następnym krokiem jest przyjrzenie się związkom. Relacje między klasami definiują sposób, w jaki obiekty utworzone z tych klas mogą współpracować w celu wykonywania operacji aplikacji. Ostatnim krokiem jest wykorzystanie ponownego użycia. Siła programowania obiektowego leży w obietnicy ponownego użycia. Poprzez wyodrębnienie podobieństwa między zestawami klas do oddzielnej klasy, masz więcej kodu wielokrotnego użytku. Rozbudowane ponowne wykorzystanie istniejących, sprawdzonych klas nie tylko skraca czas opracowywania, ale także prowadzi do bardziej niezawodnych aplikacji. Przykładowa aplikacja została ponownie wykorzystana poprzez klasę bazową z wykorzystaniem dziedziczenia. Następnie zademonstrujemy ponowne użycie poprzez bibliotekę komponentów klas ogólnych. I wreszcie, zobaczymy ponowne użycie interfejsów. Interfejsy zapewniają czysty sposób interakcji aplikacji z innymi klasami, komponentami, aplikacjami lub systemami.",
                    },
                    CourseContent = new List<Content>
                    {
                        new Content
                        {
                            Chapters = new List<Chapter>
                            {
                                new Chapter
                                {
                                    Name = "Wprowadzenie",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Wprowadzenie",
                                            Duration = "00:05:12"
                                        },
                                        new Lesson
                                        {
                                            Name = "Porównanie Obiek A Klasa",
                                            Duration = "00:10:32"
                                        },
                                        new Lesson
                                        {
                                            Name = "Co To Jest Programowanie Obiektowe",
                                            Duration = "00:20:13"
                                        },
                                        new Lesson
                                        {
                                            Name = "Konspekt Kursu",
                                            Duration = "00:26:37"
                                        },
                                        new Lesson
                                        {
                                            Name = "Quiz",
                                            Duration = "3 pytania"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Identyfikacja Klas Z Wymagań Biznesowych",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Wprowadzenie",
                                            Duration = "00:26:04"
                                        },
                                        new Lesson
                                        {
                                            Name = "Przeanalizuj Problem Biznesowy",
                                            Duration = "00:38:43"
                                        },
                                        new Lesson
                                        {
                                            Name = "Rozpoczynamy Analizę Od Rzeczowników",
                                            Duration = "00:25:34"
                                        },
                                        new Lesson
                                        {
                                            Name = "Przechodzimy Do Zdefiniowania Odpowiednich Członków",
                                            Duration = "00:23:04"
                                        },
                                        new Lesson
                                        {
                                            Name = "Określenie Naszych Celów – Abstrakcja",
                                            Duration = "00:24:54"
                                        },
                                        new Lesson
                                        {
                                            Name = "Enkapsulacja – Ukrywanie Danych",
                                            Duration = "00:22:53"
                                        },
                                        new Lesson
                                        {
                                            Name = "Podsumowanie",
                                            Duration = "00:20:09"
                                        },
                                        new Lesson
                                        {
                                            Name = "Quiz",
                                            Duration = "3 pytania"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Budowanie Klasy",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Wprowadzenie",
                                            Duration = "00:17:45"
                                        },
                                        new Lesson
                                        {
                                            Name = "Struktura Aplikacji",
                                            Duration = "00:19:31"
                                        },
                                        new Lesson
                                        {
                                            Name = "Utworzenie Warstwy Logiki Biznesowej",
                                            Duration = "00:37:12"
                                        },
                                        new Lesson
                                        {
                                            Name = "Definiowanie Właściwości",
                                            Duration = "00:23:58"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodajemy Projekt Testów Jednostkowych",
                                            Duration = "00:27:28"
                                        },
                                        new Lesson
                                        {
                                            Name = "Tworzenie Obiektów",
                                            Duration = "00:30:23"
                                        },
                                        new Lesson
                                        {
                                            Name = "Podsumowanie",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Quiz",
                                            Duration = "3 pytania"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Budowanie Klasy - Metody",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Wprowadzenie",
                                            Duration = "00:35:44"
                                        },
                                        new Lesson
                                        {
                                            Name = "Metody Klasy",
                                            Duration = "00:24:43"
                                        },
                                        new Lesson
                                        {
                                            Name = "Kilka Dodatkowych Pojęć",
                                            Duration = "00:19:39"
                                        },
                                        new Lesson
                                        {
                                            Name = "Konstruktory",
                                            Duration = "00:21:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodanie Pozostałych Klas",
                                            Duration = "00:21:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Podsumowanie",
                                            Duration = "00:21:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Quiz",
                                            Duration = "3 pytania"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Rozdzielanie Obowiązków",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Wprowadzenie",
                                            Duration = "00:21:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Diagram Klas",
                                            Duration = "00:13:08"
                                        },
                                        new Lesson
                                        {
                                            Name = "Klasa Adresów",
                                            Duration = "00:24:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Budowanie Repozytorium Klienta",
                                            Duration = "00:17:59"
                                        },
                                        new Lesson
                                        {
                                            Name = "Repozytorium Produktu I Zamówienia",
                                            Duration = "00:14:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Podsumowanie",
                                            Duration = "00:22:47"
                                        },
                                        new Lesson
                                        {
                                            Name = "Quiz",
                                            Duration = "4 pytania"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Nawiązywanie Relacji",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Wprowadzenie",
                                            Duration = "00:21:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Definiowanie Relacji",
                                            Duration = "00:13:08"
                                        },
                                        new Lesson
                                        {
                                            Name = "Typy Relacji",
                                            Duration = "00:24:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Współpraca Obiektów",
                                            Duration = "00:17:59"
                                        },
                                        new Lesson
                                        {
                                            Name = "Relacja Kompozycji",
                                            Duration = "00:14:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Kompozycja: Referencje",
                                            Duration = "00:22:47"
                                        },
                                        new Lesson
                                        {
                                            Name = "Wypełnianie Obiektów",
                                            Duration = "00:21:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Kompozycja: Identyfikatory",
                                            Duration = "00:13:08"
                                        },
                                        new Lesson
                                        {
                                            Name = "Budowanie Klas O Jednym Przeznaczeniu",
                                            Duration = "00:24:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dziedziczenie",
                                            Duration = "00:17:59"
                                        },
                                        new Lesson
                                        {
                                            Name = "Podsumowanie",
                                            Duration = "00:14:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Quiz",
                                            Duration = "4 pytania"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Wykorzystanie Ponownego Użycia",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Wprowadzenie",
                                            Duration = "00:21:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Techniki Dla Ponownego Wykorzystania",
                                            Duration = "00:13:08"
                                        },
                                        new Lesson
                                        {
                                            Name = "Klasa Object",
                                            Duration = "00:24:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Nadpisywanie Funkcjonalności Klasy Podstawowej",
                                            Duration = "00:17:59"
                                        },
                                        new Lesson
                                        {
                                            Name = "Wielopostaciowość – Polimorfizm",
                                            Duration = "00:14:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Budowanie Klasy Bazowej",
                                            Duration = "00:22:47"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dziedziczenie Z Klasy Bazowej",
                                            Duration = "00:21:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Kod Zapisu",
                                            Duration = "00:13:08"
                                        },
                                        new Lesson
                                        {
                                            Name = "Podsumowanie",
                                            Duration = "00:14:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Quiz",
                                            Duration = "4 pytania"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Budowanie Komponentu Wielokrotnego Użytku",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Wprowadzenie",
                                            Duration = "00:21:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Budowanie Komponentu Wielokrotnego Użytku",
                                            Duration = "00:13:08"
                                        },
                                        new Lesson
                                        {
                                            Name = "Testowanie Komponentu",
                                            Duration = "00:24:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Korzystanie Z Komponentu",
                                            Duration = "00:17:59"
                                        },
                                        new Lesson
                                        {
                                            Name = "Klasy Statyczne",
                                            Duration = "00:14:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Metody Rozszerzeń",
                                            Duration = "00:22:47"
                                        },
                                        new Lesson
                                        {
                                            Name = "Metoda Statyczna A Metoda Rozszerzenia",
                                            Duration = "00:21:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Podsumowanie",
                                            Duration = "00:13:08"
                                        },
                                        new Lesson
                                        {
                                            Name = "Quiz",
                                            Duration = "3 pytania"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Wprowadzenie Do Interfejsów",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Wprowadzenie",
                                            Duration = "00:21:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Interfejsy .NET",
                                            Duration = "00:13:08"
                                        },
                                        new Lesson
                                        {
                                            Name = "Logowanie",
                                            Duration = "00:24:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Definiowanie Interfejsu",
                                            Duration = "00:17:59"
                                        },
                                        new Lesson
                                        {
                                            Name = "Implementacja Interfejsu",
                                            Duration = "00:14:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Polimorfizm Oparty Na Interfejsie",
                                            Duration = "00:22:47"
                                        },
                                        new Lesson
                                        {
                                            Name = "Testy",
                                            Duration = "00:21:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Podsumowanie",
                                            Duration = "00:13:08"
                                        },
                                        new Lesson
                                        {
                                            Name = "Quiz",
                                            Duration = "3 pytania"
                                        },
                                        new Lesson
                                        {
                                            Name = "Podsumowanie kursu",
                                            Duration = "00:02:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodatkowe materiały",
                                            Duration = "Dev-hobby.pl"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Z Całkiem Innej Beczki",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Canva",
                                            Duration = "00:16:11"
                                        },
                                        new Lesson
                                        {
                                            Name = "Nozbe",
                                            Duration = "00:18:28"
                                        },
                                        new Lesson
                                        {
                                            Name = "Evernote",
                                            Duration = "00:12:26"
                                        },
                                        new Lesson
                                        {
                                            Name = "Generator Kalendarzy",
                                            Duration = "00:06:58"
                                        },
                                        new Lesson
                                        {
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
                            Question = "Co to jest abstrakcja?",
                            Answer = "Abstrakcja opisuje jednostkę w prosty sposób, ignorując nieistotne szczegóły."
                        },
                        new Faq
                        {
                            Question = "Co to jest właściwość automatycznie wdrażana?",
                            Answer = "Jest to skrót do tworzenia właściwości C# z ukrytym polem."
                        },
                        new Faq
                        {
                            Question = "Jak zbudowana jest sygnatura metody?",
                            Answer = "Składa się z nazwy i typu każdego z jej parametrów formalnych"
                        },
                        new Faq
                        {
                            Question = "Co jest zasada oddzielania obowiazków?",
                            Answer = "Dekompozycja aplikacji na części. Każda część jest odpowiedzialna za osobny problem. Definiowanie części przy minimalnym zachodzeniu na siebie."
                        }
                    },
                    Announcements = new List<Announcement>
                    {
                        new Announcement
                        {
                            Content = "Kod źródłowy dostępny na githubie : https://github.com/mariuszjurczenko/Kaczorek"
                        }
                    },
                    Opinions = new List<Opinion>
                    {
                        new Opinion
                        {
                            Content = "Kurs pomógł mi zrozumieć w jaki sposób tworzy się odpowiednie klasy i jak można sprawdzić ich działanie za pomocą testów automatycznych. Prowadzący spokojnie i logicznie wprowadza w zagadnienia programowania zorientowanego obiektowo, wspierając je praktycznymi przykładami. Polecam.",
                            NumberOfStars = 5
                        },
                        new Opinion
                        {
                            Content = "ok. Świetny kurs! Po prostu.",
                            NumberOfStars = 5
                        }
                    },
                    Category = Categories["CSHARP"]
                },
                new Course
                {
                    Name = "Seria Programista C# – część 3 – Najlepsze Praktyki Podstawy Języka",
                    Author = "Mariusz Jurczenko",
                    Price = 100,
                    ImageUrl = "https://dev-hobby.pl/wordpress/wp-content/uploads/2020/09/Programista-C-Part3.png",
                    ImageThumbnailUrl = "https://dev-hobby.pl/wordpress/wp-content/uploads/2020/09/Programista-C-Part3-300x169.png",
                    IsCourseOfTheMonth = false,
                    IsRecommended = true,
                    Description = new Description
                    {
                        Name = "C# Najlepsze Praktyki – Podstawy języka",
                        WhatWillYouLearn = new List<WhatWillYouLearn>
                        {
                            new WhatWillYouLearn
                            {
                                Content = "Gdy nauczysz się podstaw C#, to co zrobić dalej?"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Pomyśl o tym kursie jako o swojej praktyce."
                            },
                            new WhatWillYouLearn
                            {
                                Content = "C# Najlepsze Praktyki: podstawy jezyka."
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Jak budować dobre klasy, pola, właściwości, metody."
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Zobaczysz kiedy używać klas statycznych, klasy singletony."
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Overloading metod lub Overriding metod?"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Te tematy poprowadzą cię po ścieżce od ucznia do wykwalifikowanego programisty."
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Wiele przydatnych wskazówek i dobrych praktyk."
                            }
                        },
                        Requirements = new List<Requirement>
                        {
                            new Requirement
                            {
                                Content = "Chęć nauki programowania i dobrej zabawy !!!"
                            },
                            new Requirement
                            {
                                Content = "C# Podstawy programowania"
                            },
                        },
                        WhoIsThisCourseFor = new List<WhoIsThisCourseFor>
                        {
                            new WhoIsThisCourseFor
                            {
                                Content = "Programiści C#"
                            },
                            new WhoIsThisCourseFor
                            {
                                Content = "Gdy nauczysz się podstaw C#, to co zrobić dalej?"
                            },
                            new WhoIsThisCourseFor
                            {
                                Content = "Chcesz rozwijać swoje umiejętności poza podstawy?"
                            },
                            new WhoIsThisCourseFor
                            {
                                Content = "Te tematy poprowadzą cię po ścieżce od ucznia do wykwalifikowanego programisty."
                            },
                        },
                        Content = "Kiedy po raz pierwszy zacząłem swoją kariera programistyczna, szybko dowiedziałem się, że jest duża różnica między wiedzą, jak pisać kod a wiedzą jak dobrze napisać kod, i tutaj leży wyzwanie. Celem tego kursu jest nauka najlepszych praktyk podczas używania podstawowych funkcji języka C#. Prawie wszystko, co tworzymy z C# jest klasą. Najtrudniejsze jest określenie właściwych klas dla każdej warstwy aplikacji. Będziemy badać warstwy aplikacji a następnie spojrzymy na różne typy klas, które możemy stworzyć. Przyjrzymy się również testom jednostkowym. Następnym krokiem jest budowanie dobrych klasy. Przeanalizujemy kod który należy do klasy i spojrzymy na przestrzenie nazw, klasy statyczne i klasy singleton. Klasy nie robią niczego, dopóki nie zaczniemy z nich korzystać, więc dalej przyjrzymy się najlepszym praktykom do korzystania z klas, w tym inicjalizacji obiektu, lazyloading, i nowemu operatorowi warunkowemu. W ramach klasy dane są przechowywane w polach. Zbadamy jak prawidłowo definiować pola, w tym pola zaplecza, stałe i pola tylko do odczytu. Kiedy już mamy dane w naszych pola, chcemy chronić te pola z właściwościami. Omówimy najlepsze praktyki dotyczące korzystania z automatycznych właściwości. Metody zapewniają operacje dla klasy, więc większość kodu, który piszemy, będzie w ramach tych metod. Będziemy patrzeć kiedy, dlaczego i na najlepsze praktyki tworzenia dobre metody, w tym przeciążanie metod, nadpisywanie metod, metody łancuchowe. Większość metod wymaga pewnych danych, i te dane są często przekazywane do metoda przez parametry. Będziemy patrzeć na najlepsze praktyki dotyczące określania jasnych parametrów metody, w tym nazwane parametry, parametry wyliczeniowe, parametry opcjonalne i parametry ref i out. Wiekszość danych w aplikacji jest przechowywana w ciągach tekstowych, więc omówimy najlepsze praktyki dla obsługi ciągów tekstowych, w tym sprawdzanie wartości null, formatowanie ciągów tekstowych, nową funkcje interpolacji ciągów i StringBuilder.",
                    },
                    CourseContent = new List<Content>
                    {
                        new Content
                        {
                            Chapters = new List<Chapter>
                            {
                                new Chapter
                                {
                                    Name = "Wprowadzenie",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Wprowadzenie",
                                            Duration = "00:05:12"
                                        },
                                        new Lesson
                                        {
                                            Name = "Wymagania Wstępne",
                                            Duration = "00:10:32"
                                        },
                                        new Lesson
                                        {
                                            Name = "Pliki do kursu",
                                            Duration = "00:20:13"
                                        },
                                        new Lesson
                                        {
                                            Name = "Konspekt Szkolenia",
                                            Duration = "00:26:37"
                                        },
                                        new Lesson
                                        {
                                            Name = "Quiz",
                                            Duration = "3 pytania"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Definiowanie Właściwych Klas",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Wprowadzenie",
                                            Duration = "00:26:04"
                                        },
                                        new Lesson
                                        {
                                            Name = "Architektura Aplikacji",
                                            Duration = "00:38:43"
                                        },
                                        new Lesson
                                        {
                                            Name = "Architektura Aplikacji – Demo",
                                            Duration = "00:25:34"
                                        },
                                        new Lesson
                                        {
                                            Name = "Co To Jest Klasa",
                                            Duration = "00:23:04"
                                        },
                                        new Lesson
                                        {
                                            Name = "Rodzaje Klas",
                                            Duration = "00:24:54"
                                        },
                                        new Lesson
                                        {
                                            Name = "Testy Jednostkowe",
                                            Duration = "00:22:53"
                                        },
                                        new Lesson
                                        {
                                            Name = "Tworzymy Klasy",
                                            Duration = "00:20:09"
                                        },
                                        new Lesson
                                        {
                                            Name = "Testy Jednostkowe – Demo",
                                            Duration = "00:20:09"
                                        },
                                        new Lesson
                                        {
                                            Name = "Często Zadawane Pytania",
                                            Duration = "00:20:09"
                                        },
                                        new Lesson
                                        {
                                            Name = "Quiz",
                                            Duration = "4 pytania"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Budowanie Dobrych Klas",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Wprowadzenie",
                                            Duration = "00:17:45"
                                        },
                                        new Lesson
                                        {
                                            Name = "SBudowanie Klasy",
                                            Duration = "00:19:31"
                                        },
                                        new Lesson
                                        {
                                            Name = "Budowanie Klasy – Demo",
                                            Duration = "00:37:12"
                                        },
                                        new Lesson
                                        {
                                            Name = "Definiowanie Konstruktorów",
                                            Duration = "00:23:58"
                                        },
                                        new Lesson
                                        {
                                            Name = "Definiowanie Konstruktorów – Demo",
                                            Duration = "00:27:28"
                                        },
                                        new Lesson
                                        {
                                            Name = "Konstruktor Najlepsze Praktyki",
                                            Duration = "00:30:23"
                                        },
                                        new Lesson
                                        {
                                            Name = "Przestrzenie Nazw",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Budowanie Klasy Statycznej",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Budowanie Klasy Singelton",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "PCzęsto Zadawane Pytania",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Quiz",
                                            Duration = "3 pytania"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Dostęp I Korzystanie Z Klas",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Wprowadzenie",
                                            Duration = "00:35:44"
                                        },
                                        new Lesson
                                        {
                                            Name = "Referencje I Using",
                                            Duration = "00:24:43"
                                        },
                                        new Lesson
                                        {
                                            Name = "Używanie Klasy",
                                            Duration = "00:19:39"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dostęp Do Klasy",
                                            Duration = "00:21:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Tworzenie Obiektów Powiązanych",
                                            Duration = "00:21:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Null – Kontrola",
                                            Duration = "00:21:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Null – Kontrola",
                                            Duration = "00:21:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Quiz",
                                            Duration = "3 pytania"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Definijowanie Odpowiednich Pól",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Wprowadzenie",
                                            Duration = "00:21:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Pola",
                                            Duration = "00:13:08"
                                        },
                                        new Lesson
                                        {
                                            Name = "Typy Nullable",
                                            Duration = "00:24:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Stałe",
                                            Duration = "00:17:59"
                                        },
                                        new Lesson
                                        {
                                            Name = "Pola Tylko Do Odczytu",
                                            Duration = "00:14:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Stała A Pole Tylko Do Odczytu",
                                            Duration = "00:22:47"
                                        },
                                        new Lesson
                                        {
                                            Name = "Często Zadawane Pytania",
                                            Duration = "00:22:47"
                                        },
                                        new Lesson
                                        {
                                            Name = "Quiz",
                                            Duration = "4 pytania"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Tworzenie Dobrych Właściwosci",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Wprowadzenie",
                                            Duration = "00:21:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Właściwości – Geter",
                                            Duration = "00:13:08"
                                        },
                                        new Lesson
                                        {
                                            Name = "Właściwości – Seter",
                                            Duration = "00:24:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Automatycznie Implementowane Właściwości",
                                            Duration = "00:17:59"
                                        },
                                        new Lesson
                                        {
                                            Name = "Właściwości Dostępność",
                                            Duration = "00:14:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodatkowe Zastosowania Właściwości",
                                            Duration = "00:22:47"
                                        },
                                        new Lesson
                                        {
                                            Name = "Skrót Dla Składni",
                                            Duration = "00:21:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Zalety Właściwości",
                                            Duration = "00:13:08"
                                        },
                                        new Lesson
                                        {
                                            Name = "BCzęsto Zadawane Pytania",
                                            Duration = "00:24:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Quiz",
                                            Duration = "4 pytania"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Tworzenie Dobrych Metod",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Wprowadzenie",
                                            Duration = "00:21:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Budowanie Metod – Sygnatura Metody",
                                            Duration = "00:13:08"
                                        },
                                        new Lesson
                                        {
                                            Name = "Budowanie Metod – Ciało Metody I Wartość Zwracana",
                                            Duration = "00:24:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Budowanie Metod – Demo",
                                            Duration = "00:17:59"
                                        },
                                        new Lesson
                                        {
                                            Name = "Budowanie Metod – Demo cz.2",
                                            Duration = "00:14:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Właściwość Czy Metoda",
                                            Duration = "00:22:47"
                                        },
                                        new Lesson
                                        {
                                            Name = "Przeciążanie Metod",
                                            Duration = "00:21:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Metoda Łańcuchowa",
                                            Duration = "00:13:08"
                                        },
                                        new Lesson
                                        {
                                            Name = "Nadpisywanie Metody",
                                            Duration = "00:14:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Expression Bodied Methods",
                                            Duration = "00:14:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Często Zadawane Pytania",
                                            Duration = "00:14:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Quiz",
                                            Duration = "4 pytania"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Określanie Parametrów Metody",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Wprowadzenie",
                                            Duration = "00:21:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Poprawianie Parametrów W Sygnaturze Metody",
                                            Duration = "00:13:08"
                                        },
                                        new Lesson
                                        {
                                            Name = "Nazwane Argumenty",
                                            Duration = "00:24:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Definiowanie Parametrów Wyliczeniowych",
                                            Duration = "00:17:59"
                                        },
                                        new Lesson
                                        {
                                            Name = "Opcjonalne Parametry",
                                            Duration = "00:14:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Ref I Out",
                                            Duration = "00:22:47"
                                        },
                                        new Lesson
                                        {
                                            Name = "Często Zadawane Pytania",
                                            Duration = "00:21:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Quiz",
                                            Duration = "3 pytania"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Obsługa Ciagów Tekstowych (String)",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Wprowadzenie",
                                            Duration = "00:21:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Metody .Net Klasy String",
                                            Duration = "00:13:08"
                                        },
                                        new Lesson
                                        {
                                            Name = "Obsługa Null",
                                            Duration = "00:24:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dosłowne Ciągi Tekstowe",
                                            Duration = "00:17:59"
                                        },
                                        new Lesson
                                        {
                                            Name = "Formatowanie Ciągów Tekstowych",
                                            Duration = "00:14:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Interpolacja Łańcuchów Tekstowych",
                                            Duration = "00:22:47"
                                        },
                                        new Lesson
                                        {
                                            Name = "Budowanie Długich Ciągów Tekstowych",
                                            Duration = "00:21:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Często Zadawane Pytania",
                                            Duration = "00:13:08"
                                        },
                                        new Lesson
                                        {
                                            Name = "Quiz",
                                            Duration = "4 pytania"
                                        },
                                        new Lesson
                                        {
                                            Name = "Podsumowanie kursu",
                                            Duration = "33 pytania"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodatkowe materiały",
                                            Duration = "Dev-hobby.pl"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Z Całkiem Innej Beczki",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Canva",
                                            Duration = "00:16:11"
                                        },
                                        new Lesson
                                        {
                                            Name = "Nozbe",
                                            Duration = "00:18:28"
                                        },
                                        new Lesson
                                        {
                                            Name = "Evernote",
                                            Duration = "00:12:26"
                                        },
                                        new Lesson
                                        {
                                            Name = "Generator Kalendarzy",
                                            Duration = "00:06:58"
                                        },
                                        new Lesson
                                        {
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
                            Question = "Dlaczego architektura warstwowa jest ważna?",
                            Answer = "Oddziela aplikację na komponenty, które są łatwiejsze do tworzenia, zmiany, rozszerzania, ponownego wykorzystania i utrzymania."
                        },
                        new Faq
                        {
                            Question = "Co to jest singleton?",
                            Answer = "Klasa, która udostępnia tylko jedno wystąpienie samej siebie."
                        },
                        new Faq
                        {
                            Question = "Kiedy należy używać stałej w aplikacji?",
                            Answer = "Podczas definiowania pola z prostym typem danych, który nigdy się nie zmieni."
                        },
                        new Faq
                        {
                            Question = "W jaki sposób własciwość chroni pole?",
                            Answer = "Z kodem w getterze lub setterze i z odpowiednimi modyfikatorami dostępności."
                        }
                    },
                    Announcements = new List<Announcement>
                    {
                        new Announcement
                        {
                            Content = "Kod źródłowy dostępny na githubie : https://github.com/mariuszjurczenko/DevHobbyApp"
                        }
                    },
                    Opinions = new List<Opinion>
                    {
                        new Opinion
                        {
                            Content = "Kurs pomógł mi zrozumieć w jaki sposób tworzy się odpowiednie klasy i jak można sprawdzić ich działanie za pomocą testów automatycznych. Prowadzący spokojnie i logicznie wprowadza w zagadnienia programowania zorientowanego obiektowo, wspierając je praktycznymi przykładami. Polecam.",
                            NumberOfStars = 5
                        }
                    },
                    Category = Categories["DOBRE PRAKTYKI"]
                },
                new Course
                {
                    Name = "Seria Programista C# – część 4 – Wprowadzenie Do Kolekcji",
                    Author = "Mariusz Jurczenko",
                    Price = 100,
                    ImageUrl = "https://dev-hobby.pl/wordpress/wp-content/uploads/2020/09/Programista-C-Part4.png",
                    ImageThumbnailUrl = "https://dev-hobby.pl/wordpress/wp-content/uploads/2020/09/Programista-C-Part3-300x169.png",
                    IsCourseOfTheMonth = false,
                    IsRecommended = true,
                    Description = new Description
                    {
                        Name = "Wprowadzenie Do Kolekcji C#",
                        WhatWillYouLearn = new List<WhatWillYouLearn>
                        {
                            new WhatWillYouLearn
                            {
                                Content = "Jak kodować za pomocą tablic."
                            },
                            new WhatWillYouLearn
                            {
                                Content = " Jak kodować za pomocą list."
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Jak kodować za pomocą kolejki."
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Jak kodować za pomocą stosu."
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Jak kodować za pomocą słownika."
                            },
                            new WhatWillYouLearn
                            {
                                Content = "LINQ."
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Gra Kólko i krzyżyk."
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Wiele przydatnych wskazówek i dobrych praktyk."
                            }
                        },
                        Requirements = new List<Requirement>
                        {
                            new Requirement
                            {
                                Content = "Chęć nauki programowania i dobrej zabawy !!!"
                            },
                            new Requirement
                            {
                                Content = "C# Podstawy programowania"
                            },
                            new Requirement
                            {
                                Content = "Pisać proste aplikacje w języku C#"
                            },
                        },
                        WhoIsThisCourseFor = new List<WhoIsThisCourseFor>
                        {
                            new WhoIsThisCourseFor
                            {
                                Content = "Początkujący programiści języka C#."
                            },
                            new WhoIsThisCourseFor
                            {
                                Content = "Gdy nauczysz się podstaw C#, to co zrobić dalej?"
                            },
                            new WhoIsThisCourseFor
                            {
                                Content = "Chcesz rozwijać swoje umiejętności poza podstawy?"
                            }
                        },
                        Content = "W tym kursie pokażę Ci, jak kodować za pomocą prawdopodobnie najbardziej przydatnych i najczęściej używanych kolekcji, takich jak: tablica, lista, stos, kolejka i słownik oraz, co ważne, kiedy używać każdej z tych kolekcji. Nauczę cię dobrych technik wykorzystywania operacji kolekcji, takich jak wyszukiwanie, wyliczanie i modyfikowanie danych w kolekcjach, a nawet uzyskasz bardzo szybki przegląd tego, w jaki sposób LINQ może pomóc w wydobyciu danych z kolekcji. Pod koniec tego kursu powinieneś być w stanie manipulować prostymi kolekcjami w celu odpowiedniego przechowywania danych w różnych rodzajach scenariuszy, które najczęściej pojawiają się podczas pisania aplikacji i mogą pojawić się podczas pisania.",
                    },
                    CourseContent = new List<Content>
                    {
                        new Content
                        {
                            Chapters = new List<Chapter>
                            {
                                new Chapter
                                {
                                    Name = "Tablice",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Wprowadzenie",
                                            Duration = "00:05:12"
                                        },
                                        new Lesson
                                        {
                                            Name = "Co To Jest Kolekcja",
                                            Duration = "00:10:32"
                                        },
                                        new Lesson
                                        {
                                            Name = "Tablica",
                                            Duration = "00:20:13"
                                        },
                                        new Lesson
                                        {
                                            Name = "Foreach",
                                            Duration = "00:26:37"
                                        },
                                        new Lesson
                                        {
                                            Name = "Wybieranie Pojedynczego Elementu",
                                            Duration = "00:05:12"
                                        },
                                        new Lesson
                                        {
                                            Name = "Edycja Tablicy",
                                            Duration = "00:10:32"
                                        },
                                        new Lesson
                                        {
                                            Name = "Debugowanie",
                                            Duration = "00:20:13"
                                        },
                                        new Lesson
                                        {
                                            Name = "Tablica A Inne Kolekcje",
                                            Duration = "00:26:37"
                                        },
                                        new Lesson
                                        {
                                            Name = "Quiz",
                                            Duration = "4 pytania"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Tablice Praktyczny Przykład",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Wprowadzenie",
                                            Duration = "00:26:04"
                                        },
                                        new Lesson
                                        {
                                            Name = "Importowanie Danych Z Pliku",
                                            Duration = "00:38:43"
                                        },
                                        new Lesson
                                        {
                                            Name = "Tworzenie Instancji Tablicy",
                                            Duration = "00:25:34"
                                        },
                                        new Lesson
                                        {
                                            Name = "Plik CSV",
                                            Duration = "00:23:04"
                                        },
                                        new Lesson
                                        {
                                            Name = "Analiza Linii CSV",
                                            Duration = "00:24:54"
                                        },
                                        new Lesson
                                        {
                                            Name = "Wypełnianie Tablicy",
                                            Duration = "00:22:53"
                                        },
                                        new Lesson
                                        {
                                            Name = "Tworzenie Wystąpienia Tablicy",
                                            Duration = "00:20:09"
                                        },
                                        new Lesson
                                        {
                                            Name = "Quiz",
                                            Duration = "4 pytania"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Lista",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Wprowadzenie",
                                            Duration = "00:17:45"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lista Jest Bardziej Elastyczna",
                                            Duration = "00:19:31"
                                        },
                                        new Lesson
                                        {
                                            Name = "List",
                                            Duration = "00:37:12"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodawanie Elementu",
                                            Duration = "00:23:58"
                                        },
                                        new Lesson
                                        {
                                            Name = "List To Typ Ogólny",
                                            Duration = "00:27:28"
                                        },
                                        new Lesson
                                        {
                                            Name = "Importowanie Danych Z Pliku",
                                            Duration = "00:30:23"
                                        },
                                        new Lesson
                                        {
                                            Name = "Liczenie Elementów",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Wstawianie Elementu",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Wyszukiwanie Elementu",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Usuwanie Elementu",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Wydajność",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Quiz",
                                            Duration = "4 pytania"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Słownik",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Wprowadzenie",
                                            Duration = "00:35:44"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dictionary",
                                            Duration = "00:24:43"
                                        },
                                        new Lesson
                                        {
                                            Name = "Tworzenie Instancji Słownika",
                                            Duration = "00:19:39"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodawanie Elementów",
                                            Duration = "00:21:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Wyszukiwanie Elementów",
                                            Duration = "00:21:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Wyliczanie Elementów",
                                            Duration = "00:21:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Inicjaliztor Słownika",
                                            Duration = "00:21:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Klucz Jest Unikalny",
                                            Duration = "00:21:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Wyszukiwanie Elementów TryGetValue",
                                            Duration = "00:21:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Importowanie Miast Do Słownika",
                                            Duration = "00:21:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Quiz",
                                            Duration = "3 pytania"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Kolejka I Stos",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Wprowadzenie",
                                            Duration = "00:21:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Kolejka",
                                            Duration = "00:13:08"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodawanie Elementów",
                                            Duration = "00:24:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Pobieranie Elementów",
                                            Duration = "00:17:59"
                                        },
                                        new Lesson
                                        {
                                            Name = "Podgląd Elementu",
                                            Duration = "00:14:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Wyszukiwanie Elementu",
                                            Duration = "00:22:47"
                                        },
                                        new Lesson
                                        {
                                            Name = "Konwersja Do Tablicy",
                                            Duration = "00:22:47"
                                        },
                                        new Lesson
                                        {
                                            Name = "Wyczyszczenie Kolejki",
                                            Duration = "00:17:59"
                                        },
                                        new Lesson
                                        {
                                            Name = "Stos",
                                            Duration = "00:21:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodawanie Elementów",
                                            Duration = "00:13:08"
                                        },
                                        new Lesson
                                        {
                                            Name = "Pobieranie Elementów",
                                            Duration = "00:24:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Podgląd Elementu",
                                            Duration = "00:17:59"
                                        },
                                        new Lesson
                                        {
                                            Name = "Wyszukiwanie Elementu",
                                            Duration = "00:14:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Konwersja Do Tablicy",
                                            Duration = "00:22:47"
                                        },
                                        new Lesson
                                        {
                                            Name = "Wyczyszczenie Stosu",
                                            Duration = "00:22:47"
                                        },
                                        new Lesson
                                        {
                                            Name = "Importowanie Danych Z Pliku",
                                            Duration = "00:17:59"
                                        },
                                        new Lesson
                                        {
                                            Name = "Quiz",
                                            Duration = "4 pytania"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Praca Z Listami",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Wprowadzenie",
                                            Duration = "00:21:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Wyliczanie For a Foreach",
                                            Duration = "00:13:08"
                                        },
                                        new Lesson
                                        {
                                            Name = "Iterowanie Wybranych Elementów",
                                            Duration = "00:24:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Grupowanie Elementów",
                                            Duration = "00:17:59"
                                        },
                                        new Lesson
                                        {
                                            Name = "Wyliczanie Wstecz",
                                            Duration = "00:14:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Usuwanie Elementów",
                                            Duration = "00:22:47"
                                        },
                                        new Lesson
                                        {
                                            Name = "RemoveAll",
                                            Duration = "00:21:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Quiz",
                                            Duration = "4 pytania"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "LINQ",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Wprowadzenie",
                                            Duration = "00:21:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Ograniczenie Liczby Wyników",
                                            Duration = "00:13:08"
                                        },
                                        new Lesson
                                        {
                                            Name = "Sortowanie Danych",
                                            Duration = "00:24:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Łączenie Metod",
                                            Duration = "00:17:59"
                                        },
                                        new Lesson
                                        {
                                            Name = "Filtrowanie Danych",
                                            Duration = "00:14:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Inne Operacje",
                                            Duration = "00:22:47"
                                        },
                                        new Lesson
                                        {
                                            Name = "Składnia Zapytań",
                                            Duration = "00:21:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Porównanie Linq, For I Metod",
                                            Duration = "00:13:08"
                                        },
                                        new Lesson
                                        {
                                            Name = "Quiz",
                                            Duration = "4 pytania"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Kolekcje Kolekcji",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Wprowadzenie",
                                            Duration = "00:21:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Grupowanie Danych Za Pomocą Słownika",
                                            Duration = "00:13:08"
                                        },
                                        new Lesson
                                        {
                                            Name = "Importowanie Miast Do Słownika",
                                            Duration = "00:24:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Wyświetlanie Danych Ze Słownika",
                                            Duration = "00:17:59"
                                        },
                                        new Lesson
                                        {
                                            Name = "Poszczępiona Tablica",
                                            Duration = "00:14:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Kółko I Krzyżyk",
                                            Duration = "00:22:47"
                                        },
                                        new Lesson
                                        {
                                            Name = "Kółko I Krzyżyk część 2",
                                            Duration = "00:21:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Kółko I Krzyżyk część 3",
                                            Duration = "00:17:59"
                                        },
                                        new Lesson
                                        {
                                            Name = "Kółko I Krzyżyk część 4",
                                            Duration = "00:14:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Tablice Wielowymiarowe",
                                            Duration = "00:22:47"
                                        },
                                        new Lesson
                                        {
                                            Name = "Zakończenie",
                                            Duration = "00:21:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Quiz",
                                            Duration = "3 pytania"
                                        },
                                        new Lesson
                                        {
                                            Name = "Podsumowanie Kursu",
                                            Duration = "38 pytania"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodatkowe materiały",
                                            Duration = "Dev-hobby.pl"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Z Całkiem Innej Beczki",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Canva",
                                            Duration = "00:16:11"
                                        },
                                        new Lesson
                                        {
                                            Name = "Nozbe",
                                            Duration = "00:18:28"
                                        },
                                        new Lesson
                                        {
                                            Name = "Evernote",
                                            Duration = "00:12:26"
                                        },
                                        new Lesson
                                        {
                                            Name = "Generator Kalendarzy",
                                            Duration = "00:06:58"
                                        },
                                        new Lesson
                                        {
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
                            Question = "Jaka jest główna różnica między metodami Listy: Add() i Insert() ?",
                            Answer = "Add() zawsze dołącza nowy element na końcu listy, Insert() może umieścić element w dowolnym miejscu na liście."
                        },
                        new Faq
                        {
                            Question = "Wyliczanie elementów w kolekcji jest często wykonywane za pomocą pętli foreach. Dlaczego zamiast tego używać pętli for?",
                            Answer = "Aby kontrolować kolejność wyliczania elementów."
                        }
                    },
                    Announcements = new List<Announcement>
                    {
                        new Announcement
                        {
                            Content = "Kod źródłowy dostępny na githubie : https://github.com/mariuszjurczenko/BeginningCsharpCollections"
                        }
                    },
                    Opinions = new List<Opinion>
                    {
                        new Opinion
                        {
                            Content = "Kurs pomógł mi zrozumieć kolekcje w csharp. Prowadzący spokojnie i logicznie wprowadza w zagadnienia. Bardzo dobry kurs, polecam.",
                            NumberOfStars = 5
                        }
                    },
                    Category = Categories["CSHARP"]
                },
                new Course
                {
                    Name = "Seria Programista C# – część 5 – Generics",
                    Author = "Mariusz Jurczenko",
                    Price = 100,
                    ImageUrl = "https://dev-hobby.pl/wordpress/wp-content/uploads/2020/09/Programista-C-Part5.png",
                    ImageThumbnailUrl = "https://dev-hobby.pl/wordpress/wp-content/uploads/2020/09/Programista-C-Part5-300x169.png",
                    IsCourseOfTheMonth = false,
                    IsRecommended = true,
                    Description = new Description
                    {
                        Name = "C# Generics",
                        WhatWillYouLearn = new List<WhatWillYouLearn>
                        {
                            new WhatWillYouLearn
                            {
                                Content = "Podstawowe zasady, które powinieneś znać o typach Generycznych"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Pisać typy generyczne i generyczne interfejsy"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Pisać metody generyczne"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Pisać delegaty generyczne"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Zobaczysz wyrażenia lambda, metody rozszerzenia"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Zdarzenia i procedury obsługi zdarzeń"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Strategi, których możesz użyć, aby dodać ograniczenia do parametrów typu ogólnego"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Wiele przydatnych wskazówek i dobrych praktyk."
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Zbudujemy naszą własną wersjie kontenera wstrzykiwania zależności"
                            }
                        },
                        Requirements = new List<Requirement>
                        {
                            new Requirement
                            {
                                Content = "Chęć nauki programowania i dobrej zabawy !!!"
                            },
                            new Requirement
                            {
                                Content = "C# Podstawy programowania"
                            },
                            new Requirement
                            {
                                Content = "Pisać proste aplikacje w języku C#"
                            },
                        },
                        WhoIsThisCourseFor = new List<WhoIsThisCourseFor>
                        {
                            new WhoIsThisCourseFor
                            {
                                Content = "Programiści języka C#"
                            },
                            new WhoIsThisCourseFor
                            {
                                Content = "Gdy nauczysz się podstaw C#, to co zrobić dalej?"
                            },
                            new WhoIsThisCourseFor
                            {
                                Content = "Chcesz rozwijać swoje umiejętności poza podstawy?"
                            }
                        },
                        Content = "W tym kursie pokażę Ci, wszystko, co powinieneś wiedzieć o typach Generycznych w języku C#, a może nawet trochę więcej. Rozdział. 1) Pokażę podstawowe zasady, które powinieneś znać o typach Generycznych, wyjaśnić dlaczego istnieją i jakie rodzaje problemów rozwiązują. Rozdział. 2) Następnie zagłębimy się w typy generyczne z perspektywy kogoś, kto musi pisać typy generyczne. Zaczniemy również używać i pisać generyczne interfejsy. Rozdział. 3) Następnie zajmiemy się użyciem parametrów typu ogólnego do generowania poszczególnych bloków kodu. Oznacza to, że przyjrzymy się metodom, delegatom generycznym, a także przyjrzymy się wyrażeniom lambda, metodom rozszerzenia, zdarzeniom i procedurom obsługi zdarzeń, z których wszystkie mogą używać parametrów typu ogólnego, aby można było pisać bloki kodu wielokrotnego użytku. Rozdział. 4) Następnie przyjrzymy się strategiom, których możesz użyć, aby dodać ograniczenia do parametrów typu ogólnego. Rozdział. 5) Następnie stworzymy interesujący kod z typami geneycznymi. Pokaże Ci, jak używać typów generycznych przy pisaniu kodu wykorzystującego refleksję. Zbudujemy naszą własną wersji kontenera wstrzykiwaniu zależności co będzie niezwykle edukacyjne. A nasz kontener, który zbudujemy, będzie wymagał oczywiście ogólnych parametrów.",
                    },
                    CourseContent = new List<Content>
                    {
                        new Content
                        {
                            Chapters = new List<Chapter>
                            {
                                new Chapter
                                {
                                    Name = "Generic Types",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Wprowadzenie",
                                            Duration = "00:05:12"
                                        },
                                        new Lesson
                                        {
                                            Name = "Nasz Własny Stos",
                                            Duration = "00:10:32"
                                        },
                                        new Lesson
                                        {
                                            Name = "Piszemy Testy Dla Naszego Stosu",
                                            Duration = "00:20:13"
                                        },
                                        new Lesson
                                        {
                                            Name = "Użycie Naszego Stosu",
                                            Duration = "00:26:37"
                                        },
                                        new Lesson
                                        {
                                            Name = "Object",
                                            Duration = "00:05:12"
                                        },
                                        new Lesson
                                        {
                                            Name = "Kopiuj i Wklej",
                                            Duration = "00:10:32"
                                        },
                                        new Lesson
                                        {
                                            Name = "Typy Generyczne",
                                            Duration = "00:20:13"
                                        },
                                        new Lesson
                                        {
                                            Name = "Nasz Stos Generyczny",
                                            Duration = "00:26:37"
                                        },
                                        new Lesson
                                        {
                                            Name = "Terminologia",
                                            Duration = "00:20:13"
                                        },
                                        new Lesson
                                        {
                                            Name = "Podsumowanie",
                                            Duration = "00:26:37"
                                        },
                                        new Lesson
                                        {
                                            Name = "Quiz",
                                            Duration = "4 pytania"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Generic Classes And Interfaces",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Wprowadzenie",
                                            Duration = "00:26:04"
                                        },
                                        new Lesson
                                        {
                                            Name = "Nowe Wymagania",
                                            Duration = "00:38:43"
                                        },
                                        new Lesson
                                        {
                                            Name = "Nasz Własny Interface",
                                            Duration = "00:25:34"
                                        },
                                        new Lesson
                                        {
                                            Name = "Nasza własna Kolekcja",
                                            Duration = "00:23:04"
                                        },
                                        new Lesson
                                        {
                                            Name = "Nasz Kolejny Stos",
                                            Duration = "00:24:54"
                                        },
                                        new Lesson
                                        {
                                            Name = "Kolejka Nadpisująca",
                                            Duration = "00:22:53"
                                        },
                                        new Lesson
                                        {
                                            Name = "IEnumerable",
                                            Duration = "00:20:09"
                                        },
                                        new Lesson
                                        {
                                            Name = "Interfejsy kolekcji",
                                            Duration = "00:23:04"
                                        },
                                        new Lesson
                                        {
                                            Name = "CarComparer",
                                            Duration = "00:24:54"
                                        },
                                        new Lesson
                                        {
                                            Name = "Czyszczenie",
                                            Duration = "00:22:53"
                                        },
                                        new Lesson
                                        {
                                            Name = "Podsumowanie",
                                            Duration = "00:20:09"
                                        },
                                        new Lesson
                                        {
                                            Name = "Quiz",
                                            Duration = "4 pytania"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Generic Methods And Delegates",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Wprowadzenie",
                                            Duration = "00:17:45"
                                        },
                                        new Lesson
                                        {
                                            Name = "Metody Generyczne",
                                            Duration = "00:19:31"
                                        },
                                        new Lesson
                                        {
                                            Name = "Metody Rozszerzenia",
                                            Duration = "00:37:12"
                                        },
                                        new Lesson
                                        {
                                            Name = "Refactoring",
                                            Duration = "00:23:58"
                                        },
                                        new Lesson
                                        {
                                            Name = "Delegaty Generyczne",
                                            Duration = "00:27:28"
                                        },
                                        new Lesson
                                        {
                                            Name = "Action",
                                            Duration = "00:30:23"
                                        },
                                        new Lesson
                                        {
                                            Name = "Func",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Predicate",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Konwerter",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Zdarzenia Generyczne",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Podsumowanie",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Quiz",
                                            Duration = "4 pytania"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Generic Constraints",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Wprowadzenie",
                                            Duration = "00:35:44"
                                        },
                                        new Lesson
                                        {
                                            Name = "Ograniczenia",
                                            Duration = "00:24:43"
                                        },
                                        new Lesson
                                        {
                                            Name = "Model",
                                            Duration = "00:19:39"
                                        },
                                        new Lesson
                                        {
                                            Name = "Cel Naszej Aplikacji",
                                            Duration = "00:21:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Repozytorium i ograniczenia",
                                            Duration = "00:21:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Repozytorium",
                                            Duration = "00:21:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Ograniczenie Interfejsu",
                                            Duration = "00:21:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Ograniczenia",
                                            Duration = "00:21:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Kowariancja",
                                            Duration = "00:21:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Kontrawariancja",
                                            Duration = "00:21:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Podsumowanie",
                                            Duration = "00:21:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Quiz",
                                            Duration = "3 pytania"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Generics And Reflection",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Wprowadzenie",
                                            Duration = "00:21:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Tworzenie Instancji Typów Ogólnych",
                                            Duration = "00:13:08"
                                        },
                                        new Lesson
                                        {
                                            Name = "Wywoływanie Metod Ogólnych",
                                            Duration = "00:24:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Nasz Własny Kontener",
                                            Duration = "00:17:59"
                                        },
                                        new Lesson
                                        {
                                            Name = "Pierwsza Funkcja Naszego Kontenera",
                                            Duration = "00:14:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Praca Z Konstruktorami",
                                            Duration = "00:22:47"
                                        },
                                        new Lesson
                                        {
                                            Name = "Praca Z Niezwiązanymi Typami",
                                            Duration = "00:22:47"
                                        },
                                        new Lesson
                                        {
                                            Name = "Podsumowanie",
                                            Duration = "00:17:59"
                                        },
                                        new Lesson
                                        {
                                            Name = "Quiz",
                                            Duration = "3 pytania"
                                        },
                                        new Lesson
                                        {
                                            Name = "Podsumowanie kursu",
                                            Duration = "00:21:27"
                                        },
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Z Całkiem Innej Beczki",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Canva",
                                            Duration = "00:16:11"
                                        },
                                        new Lesson
                                        {
                                            Name = "Nozbe",
                                            Duration = "00:18:28"
                                        },
                                        new Lesson
                                        {
                                            Name = "Evernote",
                                            Duration = "00:12:26"
                                        },
                                        new Lesson
                                        {
                                            Name = "Generator Kalendarzy",
                                            Duration = "00:06:58"
                                        },
                                        new Lesson
                                        {
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
                            Question = "Dlaczego powstały typy generyczne?",
                            Answer = "Celem było umożliwienie nam ponownego użycia większej ilości kodu, przy jednoczesnym zachowaniu bezpieczeństwa typów."
                        },
                        new Faq
                        {
                            Question = "Czy możemy mieć interfejsy generyczne?",
                            Answer = "Tak."
                        }
                    },
                    Announcements = new List<Announcement>
                    {
                        new Announcement
                        {
                            Content = "Kod źródłowy dostępny na githubie : https://github.com/mariuszjurczenko/Generics"
                        }
                    },
                    Opinions = new List<Opinion>
                    {
                        new Opinion
                        {
                            Content = "Obszerne omówienie typów generycznych w C# z praktyczną prezentacją przeprowadzania testów jednostkowych. Polecam kurs prowadzony spokojnie a czasami nawet humorystycznie (w sposób chyba niezamierzony ale to dobrze bo \"uczy bawiąc\"). Wiele praktycznych wskazówek dotyczących środowiska Visual Studio.",
                            NumberOfStars = 5
                        }
                    },
                    Category = Categories["CSHARP"]
                },
                new Course
                {
                    Name = "ASP.NET Core 2.1 MVC – Seria Web Developer – część 1",
                    Author = "Mariusz Jurczenko",
                    Price = 100,
                    ImageUrl = "https://dev-hobby.pl/wordpress/wp-content/uploads/2020/09/ASP.NET-Core-2.1-MVC-Web-Devrloper.png",
                    ImageThumbnailUrl = "https://dev-hobby.pl/wordpress/wp-content/uploads/2020/09/ASP.NET-Core-2.1-MVC-Web-Devrloper-300x169.png",
                    IsCourseOfTheMonth = true,
                    IsRecommended = true,
                    Description = new Description
                    {
                        Name = "Budowanie pierwszej aplikacji ASP.NET Core 2.1 MVC z Visual Studio 2017",
                        WhatWillYouLearn = new List<WhatWillYouLearn>
                        {
                            new WhatWillYouLearn
                            {
                                Content = "Będziesz wiedział, jak zbudować pełną aplikację za pomocą ASP_NET Core 2.1 MVC"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Zdobędziesz umiejętności, które zapewnią Ci szansę na wspaniałą karierę zawodową"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "W krótkim czasie poznasz zupełnie od podstaw proces budowania aplikacji ASP_NET Core 2.1 MVC"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Opanujesz liczne pojęcia, koncepcje oraz techniki, których znajomość jest niezbędna podczas tworzenia nowoczesnych aplikacji"
                            }
                        },
                        Requirements = new List<Requirement>
                        {
                            new Requirement
                            {
                                Content = "Chęć nauki programowania i dobrej zabawy !!!"
                            },
                            new Requirement
                            {
                                Content = "Przed rozpoczęciem tego kursu powinieneś zapoznać się z podstawami C#"
                            }
                        },
                        WhoIsThisCourseFor = new List<WhoIsThisCourseFor>
                        {
                            new WhoIsThisCourseFor
                            {
                                Content = "Początkujący programista AspNet Core"
                            },
                            new WhoIsThisCourseFor
                            {
                                Content = "Początkujący programiści AspNet Mvc"
                            },
                            new WhoIsThisCourseFor
                            {
                                Content = "Chcesz w krótkim czasie poznać zupełnie od podstaw kompletny proces budowania aplikacji z ASP_NET Core"
                            },
                            new WhoIsThisCourseFor
                            {
                                Content = "Chcesz w praktyce wykorzystać swoją znajomość języka C# i zdobyć umiejętności, które zapewnią Ci szansę na wspaniałą karierę zawodową"
                            },
                            new WhoIsThisCourseFor
                            {
                                Content = "Chcesz opanować liczne pojęcia, koncepcje oraz techniki, których znajomość jest niezbędna podczas tworzenia nowoczesnych aplikacji"
                            }
                        },
                        Content = "W kursie będziemy budować naszą pierwszą aplikację ASP.NET Core 2.1 MVC z Visual Studio 2017. Ten kurs ma na celu dać ci praktyczny sposób, aby dowiedzieć się jak najwięcej o ASP.NET Core 2.1 MVC. Zbudujemy pełną aplikację w Visual Studio 2017. Dowiesz się jak robimy konfigurowanie witryny. Zobaczysz, jak zastosować wzór MVC, tworzyć model, repozytorium, budować widoki, pracować z prawdziwą bazą danych i wiele więcej. Niektóre z głównych tematów, które omówimy, to budowa w pełni działającej aplikacji, zaczynając od Plik -> Nowy Projekt. Dowiesz się o nowych funkcjach ASP.NET Core 2.1 MVC, takich jak : Tag helpers, dostęp do danych w bazie danych, przy użyciu Entity Framework Core 2, omówimy ASP.NET identity, aby umożliwić użytkownikom uwierzytelnianie w naszej witrynie. Pod koniec tego kursu będziecie wiedzieć, jak zbudować w pełni działającą, rzeczywistą aplikację przy użyciu ASP.NET Core 2.1 MVC w Visual Studio 2017.",
                    },
                    CourseContent = new List<Content>
                    {
                        new Content
                        {
                            Chapters = new List<Chapter>
                            {
                                new Chapter
                                {
                                    Name = "Wprowadenie",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Wprowadzenie",
                                            Duration = "00:05:12"
                                        },
                                        new Lesson
                                        {
                                            Name = "Przegląd Kursu",
                                            Duration = "00:10:32"
                                        },
                                        new Lesson
                                        {
                                            Name = "Ostateczna Aplikacja",
                                            Duration = "00:20:13"
                                        },
                                        new Lesson
                                        {
                                            Name = "Co To Jest Asp.Net Core",
                                            Duration = "00:26:37"
                                        },
                                        new Lesson
                                        {
                                            Name = "Przygotowanie Komputera Do Pracy",
                                            Duration = "00:05:12"
                                        },
                                        new Lesson
                                        {
                                            Name = "Przygotowanie Komputera Do Pracy – Demo",
                                            Duration = "00:10:32"
                                        },
                                        new Lesson
                                        {
                                            Name = "Podsumowanie",
                                            Duration = "00:26:37"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Konfigurowanie Witryny",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Wprowadzenie",
                                            Duration = "00:26:04"
                                        },
                                        new Lesson
                                        {
                                            Name = "Poznawanie Struktury Projektu",
                                            Duration = "00:38:43"
                                        },
                                        new Lesson
                                        {
                                            Name = "Tworzenie Nowej Aplikacji – Demo",
                                            Duration = "00:25:34"
                                        },
                                        new Lesson
                                        {
                                            Name = "Konfigurowanie Witryny",
                                            Duration = "00:23:04"
                                        },
                                        new Lesson
                                        {
                                            Name = "NKonfigurowanie Witryny – Demo",
                                            Duration = "00:24:54"
                                        },
                                        new Lesson
                                        {
                                            Name = "Podsumowanie",
                                            Duration = "00:20:09"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Tworzenie Pierwszej Strony Listy Samochodów",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Wprowadzenie",
                                            Duration = "00:17:45"
                                        },
                                        new Lesson
                                        {
                                            Name = "Wzorzec MVC",
                                            Duration = "00:19:31"
                                        },
                                        new Lesson
                                        {
                                            Name = "Tworzenie Modelu I Repozytorium",
                                            Duration = "00:37:12"
                                        },
                                        new Lesson
                                        {
                                            Name = "Tworzenie Modelu I Repozytorium – Demo",
                                            Duration = "00:23:58"
                                        },
                                        new Lesson
                                        {
                                            Name = "Tworzenie Kontrolera",
                                            Duration = "00:27:28"
                                        },
                                        new Lesson
                                        {
                                            Name = "Tworzenie Kontrolera - Demo",
                                            Duration = "00:30:23"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodawanie Widoku",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodawanie Widoku - Demo",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Stylizacja Widoku",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Stylizacja Widoku - Demo",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Podsumowanie",
                                            Duration = "00:21:33"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Dodawanie Danych Za Pomocą Entity Framework Core",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Wprowadzenie",
                                            Duration = "00:35:44"
                                        },
                                        new Lesson
                                        {
                                            Name = "EF Core",
                                            Duration = "00:24:43"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodanie EF Core Do Aplikacji",
                                            Duration = "00:19:39"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodanie EF Core Do Aplikacji – Demo",
                                            Duration = "00:21:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Inicjowanie Bazy Danych",
                                            Duration = "00:21:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Inicjowanie Bazy Danych - Demo",
                                            Duration = "00:21:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Modyfikowanie Modelu",
                                            Duration = "00:21:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Modyfikowanie Modelu - Demo",
                                            Duration = "00:21:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Podsumowanie",
                                            Duration = "00:21:50"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Dodawanie Nawigacji Do Witryny",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Wprowadzenie",
                                            Duration = "00:21:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Zrozumienie Nawigacji W MVC",
                                            Duration = "00:13:08"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodawanie Nawigacji",
                                            Duration = "00:24:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodawanie Nawigacji - Demo",
                                            Duration = "00:17:59"
                                        },
                                        new Lesson
                                        {
                                            Name = "Podsumowanie",
                                            Duration = "00:17:59"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Tworzenie Formularza",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Wprowadzenie",
                                            Duration = "00:21:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Używanie Tag Helpers",
                                            Duration = "00:13:08"
                                        },
                                        new Lesson
                                        {
                                            Name = "Tworzenie Formularza – Demo",
                                            Duration = "00:24:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Wiązanie I Walidacja Modelu",
                                            Duration = "00:17:59"
                                        },
                                        new Lesson
                                        {
                                            Name = "Sprawdzanie Poprawności Modelu – Demo",
                                            Duration = "00:17:59"
                                        },
                                        new Lesson
                                        {
                                            Name = "Podsumowanie",
                                            Duration = "00:17:59"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Dodanie Możliwości Rejestracji I Logowania Do Witryny",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Wprowadzenie",
                                            Duration = "00:21:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Odkrywanie ASP.NET Core Identity",
                                            Duration = "00:13:08"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodawanie ASP.NET Identity – Demo",
                                            Duration = "00:24:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodawanie Uwierzytelniania Do Witryny",
                                            Duration = "00:17:59"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodawanie Widoku Logowania i Widoku Rejestracji",
                                            Duration = "00:17:59"
                                        },
                                        new Lesson
                                        {
                                            Name = "Autoryzacja Użytkowników",
                                            Duration = "00:17:59"
                                        },
                                        new Lesson
                                        {
                                            Name = "Autoryzacja Użytkowników - Demo",
                                            Duration = "00:17:59"
                                        },
                                        new Lesson
                                        {
                                            Name = "Podsumowanie",
                                            Duration = "00:17:59"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Operacje CRUD",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "CRUD Wykorzystanie Szablonu",
                                            Duration = "00:21:27"
                                        },
                                        new Lesson
                                        {
                                            Name = "Repozytorium",
                                            Duration = "00:13:08"
                                        },
                                        new Lesson
                                        {
                                            Name = "Kontroler",
                                            Duration = "00:24:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Szczegóły",
                                            Duration = "00:17:59"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodaj",
                                            Duration = "00:17:59"
                                        },
                                        new Lesson
                                        {
                                            Name = "Edycja",
                                            Duration = "00:17:59"
                                        },
                                        new Lesson
                                        {
                                            Name = "Usuń",
                                            Duration = "00:17:59"
                                        },
                                        new Lesson
                                        {
                                            Name = "Przesyłanie Zdjęć – Formularz",
                                            Duration = "00:17:59"
                                        },
                                        new Lesson
                                        {
                                            Name = "Przesyłanie Zdjęć",
                                            Duration = "00:17:59"
                                        },
                                        new Lesson
                                        {
                                            Name = "Usuwanie Zdjęć",
                                            Duration = "00:17:59"
                                        },
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Z Całkiem Innej Beczki",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Canva",
                                            Duration = "00:16:11"
                                        },
                                        new Lesson
                                        {
                                            Name = "Nozbe",
                                            Duration = "00:18:28"
                                        },
                                        new Lesson
                                        {
                                            Name = "Evernote",
                                            Duration = "00:12:26"
                                        },
                                        new Lesson
                                        {
                                            Name = "Generator Kalendarzy",
                                            Duration = "00:06:58"
                                        },
                                        new Lesson
                                        {
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
                            Question = "Pytanie 1",
                            Answer = "Odpowiedz na pierwszr czesto zadawane pytanie"
                        }
                    },
                    Announcements = new List<Announcement>
                    {
                        new Announcement
                        {
                            Content = "Kod źródłowy dostępny na githubie : https://github.com/mariuszjurczenko/Komis"
                        }
                    },
                    Opinions = new List<Opinion>
                    {
                        new Opinion
                        {
                            Content = "Obszerne omówienie tematu. Polecam kurs prowadzony spokojnie a czasami nawet humorystycznie",
                            NumberOfStars = 5
                        }
                    },
                    Category = Categories["ASP NET CORE"]
                },
                new Course
                {
                    Name = "HTML5, CSS, JavaScript, jQuery – Seria Web Developer – część 2",
                    Author = "Mariusz Jurczenko",
                    Price = 100,
                    ImageUrl = "https://dev-hobby.pl/wordpress/wp-content/uploads/2020/09/HTML-CSS-JAVASCRIPT-JQUERY.png",
                    ImageThumbnailUrl = "https://dev-hobby.pl/wordpress/wp-content/uploads/2020/09/HTML-CSS-JAVASCRIPT-JQUERY-300x169.png",
                    IsCourseOfTheMonth = false,
                    IsRecommended = false,
                    Description = new Description
                    {
                        Name = "HTML5, CSS, JavaScript, jQuery Szybki Start dla .Net Core – Seria Web Developer część 2",
                        WhatWillYouLearn = new List<WhatWillYouLearn>
                        {
                            new WhatWillYouLearn
                            {
                                Content = "Poznasz podstawy HTML"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Poznasz podstawy CSS"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Poznasz podstawy JavaScript"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Poznasz podstawy jQuery"
                            }
                        },
                        Requirements = new List<Requirement>
                        {
                            new Requirement
                            {
                                Content = "Chęć nauki i dobrej zabawy !!!"
                            }
                        },
                        WhoIsThisCourseFor = new List<WhoIsThisCourseFor>
                        {
                            new WhoIsThisCourseFor
                            {
                                Content = "Początkujący twórca stron internetowych"
                            },
                            new WhoIsThisCourseFor
                            {
                                Content = "Początkujący programista AspNet Core"
                            },
                            new WhoIsThisCourseFor
                            {
                                Content = "Początkujący programiści AspNet Mvc"
                            }
                        },
                        Content = "Witam w szybkim kursie tworzenia stron WWW dla początkujących z HTML5, CSS, JavaScript i Jquery. Jeśli zaczynasz ten kurs, to wiedz że nauczysz się pewnych umiejętności związanych z tworzeniem stron internetowych. Ten kurs w szczególności pomoże Ci nauczyć się HTMLa, stylizacji strony za pomocą CSSa, a także obsługi kodu po stronie klienta za pomocą JavaScriptu i Jquery. Celem tego kursu nie jest nabycie kompletnej wiedzy, ale umożliwienie Ci w ciągu kilku godzin zrozumienia podstawowych pojęć HTML, CSS, JavaScript i Jquery. Zamiast pokazywać wiele slajdów, skupimy się w większości na praktycznych przykładach. Przejdziemy przez prosty przykład strony internetowej i pokażemy, jak zbudować HTML, zmienić sposób, w jaki on wygląda za pomocą CSS, a następnie w końcu napisać kod do rzeczywistej interakcji z użytkownikiem oraz z żądaniami sieciowymi za pomocą JavaScriptu. Dzięki poznaniu podstaw i ich wspólnej pracy możesz zacząć szybko działać. Podczas tego kursu zapoznam Cię z podstawami tworzenia stron WWW po stronie klienta, pokazując podstawy budowania stron internetowych za pomocą HTML, CSS, JavaScript i jQuery.",
                    },
                    CourseContent = new List<Content>
                    {
                        new Content
                        {
                            Chapters = new List<Chapter>
                            {
                                new Chapter
                                {
                                    Name = "HTML",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Wprowadzenie",
                                            Duration = "00:05:12"
                                        },
                                        new Lesson
                                        {
                                            Name = "Co To Jest HTML",
                                            Duration = "00:10:32"
                                        },
                                        new Lesson
                                        {
                                            Name = "Znaczniki HTML",
                                            Duration = "00:20:13"
                                        },
                                        new Lesson
                                        {
                                            Name = "Struktura Strony Html5",
                                            Duration = "00:26:37"
                                        },
                                        new Lesson
                                        {
                                            Name = "Emmet",
                                            Duration = "00:05:12"
                                        },
                                        new Lesson
                                        {
                                            Name = "Tagi",
                                            Duration = "00:10:32"
                                        },
                                        new Lesson
                                        {
                                            Name = "Formularze",
                                            Duration = "00:10:32"
                                        },
                                        new Lesson
                                        {
                                            Name = "Nowe Pola Formularza",
                                            Duration = "00:10:32"
                                        },
                                        new Lesson
                                        {
                                            Name = "Cross Browser HTML",
                                            Duration = "00:10:32"
                                        },
                                        new Lesson
                                        {
                                            Name = "Podsumowanie",
                                            Duration = "00:26:37"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Css Stylizacja HTMLa",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Wprowadzenie",
                                            Duration = "00:26:04"
                                        },
                                        new Lesson
                                        {
                                            Name = "Stylizacja HTMLa",
                                            Duration = "00:38:43"
                                        },
                                        new Lesson
                                        {
                                            Name = "Tag Style",
                                            Duration = "00:25:34"
                                        },
                                        new Lesson
                                        {
                                            Name = "Wprowadzenie CSS",
                                            Duration = "00:23:04"
                                        },
                                        new Lesson
                                        {
                                            Name = "ID Selektory",
                                            Duration = "00:24:54"
                                        },
                                        new Lesson
                                        {
                                            Name = "Selektory Względne",
                                            Duration = "00:24:54"
                                        },
                                        new Lesson
                                        {
                                            Name = "Selektory – Klas",
                                            Duration = "00:24:54"
                                        },
                                        new Lesson
                                        {
                                            Name = "Rozmiar I Model Pudełkowy",
                                            Duration = "00:24:54"
                                        },
                                        new Lesson
                                        {
                                            Name = "Pozycjonowanie W CSS",
                                            Duration = "00:24:54"
                                        },
                                        new Lesson
                                        {
                                            Name = "Wyświetlanie w CSS",
                                            Duration = "00:24:54"
                                        },
                                        new Lesson
                                        {
                                            Name = "Float W CSS",
                                            Duration = "00:24:54"
                                        },
                                        new Lesson
                                        {
                                            Name = "Debugowanie Styli W Przeglądarce",
                                            Duration = "00:24:54"
                                        },
                                        new Lesson
                                        {
                                            Name = "Podsumowanie",
                                            Duration = "00:20:09"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "JavaScript",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Wprowadzenie",
                                            Duration = "00:17:45"
                                        },
                                        new Lesson
                                        {
                                            Name = "Co To Jest JavaScript",
                                            Duration = "00:19:31"
                                        },
                                        new Lesson
                                        {
                                            Name = "Witaj JavaScript",
                                            Duration = "00:37:12"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dołączanie JavaScriptu Do Strony HTML",
                                            Duration = "00:23:58"
                                        },
                                        new Lesson
                                        {
                                            Name = "Zmienne I Typy",
                                            Duration = "00:27:28"
                                        },
                                        new Lesson
                                        {
                                            Name = "Waruki",
                                            Duration = "00:30:23"
                                        },
                                        new Lesson
                                        {
                                            Name = "Funkcje",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Zakresy (Scopes)",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Zamknięcia (Closures)",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Obiekty I Tablice",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Pętle",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Podsumowanie",
                                            Duration = "00:21:33"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "jQuery",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Wprowadzenie",
                                            Duration = "00:35:44"
                                        },
                                        new Lesson
                                        {
                                            Name = "Co To Jest jQuery",
                                            Duration = "00:24:43"
                                        },
                                        new Lesson
                                        {
                                            Name = "Podstawy jQuery",
                                            Duration = "00:19:39"
                                        },
                                        new Lesson
                                        {
                                            Name = "Obsługa Zdarzeń W jQuery",
                                            Duration = "00:21:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Zapytania Za Pomocą jQuery",
                                            Duration = "00:21:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Modyfikowanie Strony Z jQuery",
                                            Duration = "00:21:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Żądania Sieciowe Z jQuery",
                                            Duration = "00:21:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Praca Z Formularzami Z jQuery",
                                            Duration = "00:21:50"
                                        },
                                        new Lesson
                                        {
                                            Name = "Podsumowanie",
                                            Duration = "00:21:50"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Z Całkiem Innej Beczki",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Canva",
                                            Duration = "00:16:11"
                                        },
                                        new Lesson
                                        {
                                            Name = "Nozbe",
                                            Duration = "00:18:28"
                                        },
                                        new Lesson
                                        {
                                            Name = "Evernote",
                                            Duration = "00:12:26"
                                        },
                                        new Lesson
                                        {
                                            Name = "Generator Kalendarzy",
                                            Duration = "00:06:58"
                                        },
                                        new Lesson
                                        {
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
                            Question = "Pytanie 1",
                            Answer = "Odpowiedz na pierwszr czesto zadawane pytanie"
                        }
                    },
                    Announcements = new List<Announcement>
                    {
                        new Announcement
                        {
                            Content = "Kod źródłowy dostępny na githubie : https://github.com/mariuszjurczenko/HtmlCssJS"
                        }
                    },
                    Opinions = new List<Opinion>
                    {
                        new Opinion
                        {
                            Content = "Polecam dobry kurs prowadzony spokojnie a nawet humorystycznie",
                            NumberOfStars = 5
                        }
                    },
                    Category = Categories["JAVA SCRIPT"]
                },
                new Course
                {
                    Name = "Portal Randkowy – Seria Web Developer – część 3",
                    Author = "Mariusz Jurczenko",
                    Price = 100,
                    ImageUrl = "https://dev-hobby.pl/wordpress/wp-content/uploads/2020/09/Web-Developer-Portal-Randkowy.png",
                    ImageThumbnailUrl = "https://dev-hobby.pl/wordpress/wp-content/uploads/2020/09/Web-Developer-Portal-Randkowy-300x169.png",
                    IsCourseOfTheMonth = true,
                    IsRecommended = true,
                    Description = new Description
                    {
                        Name = "Budowanie aplikacji ASP.NET Core 2.2 Web API z wykorzystaniem Angular 8",
                        WhatWillYouLearn = new List<WhatWillYouLearn>
                        {
                            new WhatWillYouLearn
                            {
                                Content = "Dowiesz się, jak zbudować aplikację internetową od początku do publikacji."
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Zdobędziesz praktyczną wiedzę na temat ASPNET Core, Entity Framework Core i Angular (v8)."
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Dowiesz się, jak wdrożyć system przesyłania wiadomości."
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Dowiesz się, jak zaimplementować uwierzytelnianie za pomocą tokenów JWT."
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Dowiesz się, jak zorganizować aplikację Angular przy użyciu najlepszych praktyk."
                            },
                            new WhatWillYouLearn
                            {
                                Content = "I wiele więcej..."
                            }
                        },
                        Requirements = new List<Requirement>
                        {
                            new Requirement
                            {
                                Content = "Pasja i chęci nauczenia się, jak zbudować w pełni funkcjonalną aplikację internetową."
                            }
                        },
                        WhoIsThisCourseFor = new List<WhoIsThisCourseFor>
                        {
                            new WhoIsThisCourseFor
                            {
                                Content = "Początkujący w ASPNET Core i Angular."
                            },
                            new WhoIsThisCourseFor
                            {
                                Content = "Wszyscy którzy chcą zbudować atrakcyjną i funkcjonalną aplikację."
                            },
                            new WhoIsThisCourseFor
                            {
                                Content = "Wszyscy którzy lubią się uczyć przez praktykę!!!"
                            }
                        },
                        Content = "W tym kursie będziemy budować jeden duży praktyczny projekt “Portal Randkowy”. Będziemy go budować od początku do końca łącznie z opublikowaniem w sieci, gdzie będzie można go przetestować!!! Może nawet znaleźć swoją drugą połówkę! Ten kurs jest bardzo praktyczny, lekcje będą wymagały kodowania !!! Jeśli jesteś typem osoby, która lubi uczyć się przez praktykę, to ten kurs jest zdecydowanie dla Ciebie !!! Wszystko, czego potrzebujesz, aby rozpocząć, to komputer z twoim ulubionym systemem operacyjnym i pasja do nauki tworzenia aplikacji przy użyciu ASP.NET Core i Angular.",
                    },
                    CourseContent = new List<Content>
                    {
                        new Content
                        {
                            Chapters = new List<Chapter>
                            {
                                new Chapter
                                {
                                    Name = "Rozpoczęcie Projektu Portal Randkowy",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Przygotowanie Do Rozpoczęcia Projektu",
                                            Duration = "00:05:12"
                                        },
                                        new Lesson
                                        {
                                            Name = "Utworzenie Projektu Portal Randkowy Web API",
                                            Duration = "00:10:32"
                                        },
                                        new Lesson
                                        {
                                            Name = "Przeglądanie Plików Startowych Projektu Web API",
                                            Duration = "00:20:13"
                                        },
                                        new Lesson
                                        {
                                            Name = "Uruchomienie Projektu Web API",
                                            Duration = "00:26:37"
                                        },
                                        new Lesson
                                        {
                                            Name = "Utworzenie Pierwszego Modelu",
                                            Duration = "00:05:12"
                                        },
                                        new Lesson
                                        {
                                            Name = "Utworzenie Bazy Danych",
                                            Duration = "00:10:32"
                                        },
                                        new Lesson
                                        {
                                            Name = "Pobieranie Danych Z Bazy Danych",
                                            Duration = "00:10:32"
                                        },
                                        new Lesson
                                        {
                                            Name = "Przechodzimy Na Kod Asynchroniczny",
                                            Duration = "00:10:32"
                                        },
                                        new Lesson
                                        {
                                            Name = "Utworzenie Aplikacji SPA Z Angular 8",
                                            Duration = "00:10:32"
                                        },
                                        new Lesson
                                        {
                                            Name = "Uruchomienie Aplikacji Angular",
                                            Duration = "00:26:37"
                                        },
                                        new Lesson
                                        {
                                            Name = "Wykonywanie Żądań HTTP W Angular",
                                            Duration = "00:26:37"
                                        },
                                        new Lesson
                                        {
                                            Name = "Wyświetlanie Danych Na Stronie Z API",
                                            Duration = "00:26:37"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodanie Bootstrap I Fontawesome Do Naszej Aplikacji",
                                            Duration = "00:26:37"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Zabezpieczenie Aplikacji",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Wprowadzenie",
                                            Duration = "00:26:04"
                                        },
                                        new Lesson
                                        {
                                            Name = "Utworzenie Klasy Użytkownik",
                                            Duration = "00:38:43"
                                        },
                                        new Lesson
                                        {
                                            Name = "Utworzenie Interfejsu Do Autoryzacji",
                                            Duration = "00:25:34"
                                        },
                                        new Lesson
                                        {
                                            Name = "Utworzenie Repozytorium Do Autoryzacji",
                                            Duration = "00:23:04"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodanie Metody Logowania Użytkownika",
                                            Duration = "00:24:54"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodanie Kontrolera Do Autoryzacji",
                                            Duration = "00:24:54"
                                        },
                                        new Lesson
                                        {
                                            Name = "Utworzenie DTO",
                                            Duration = "00:24:54"
                                        },
                                        new Lesson
                                        {
                                            Name = "Walidacja",
                                            Duration = "00:24:54"
                                        },
                                        new Lesson
                                        {
                                            Name = "Kontroler dodanie Metody Logowania",
                                            Duration = "00:24:54"
                                        },
                                        new Lesson
                                        {
                                            Name = "Użycie Uwierzytelniania",
                                            Duration = "00:24:54"
                                        },
                                        new Lesson
                                        {
                                            Name = "Utworzenie Komponentu Nawigacyjnego",
                                            Duration = "00:24:54"
                                        },
                                        new Lesson
                                        {
                                            Name = "Formularz Logowania",
                                            Duration = "00:24:54"
                                        },
                                        new Lesson
                                        {
                                            Name = "Utworzenie Naszej Pierwszej Usługi",
                                            Duration = "00:20:09"
                                        },
                                        new Lesson
                                        {
                                            Name = "Użycie Naszej Usługi W Komponencie",
                                            Duration = "00:24:54"
                                        },
                                        new Lesson
                                        {
                                            Name = "Warunkowe Wyświetlanie Elementu Na Stronie",
                                            Duration = "00:24:54"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodajemy Komponent Rejestracji Użytkownika",
                                            Duration = "00:24:54"
                                        },
                                        new Lesson
                                        {
                                            Name = "Komunikacja Komponentów Od Rodzica Do Dziecka",
                                            Duration = "00:24:54"
                                        },
                                        new Lesson
                                        {
                                            Name = "Komunikacja Komponentów Od Dziecka Do Rodzica",
                                            Duration = "00:20:09"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodajemy Metodę Rejestracji Użytkowników",
                                            Duration = "00:24:54"
                                        },
                                        new Lesson
                                        {
                                            Name = "Wyświetlanie Powiadomień Dla Użytkownika",
                                            Duration = "00:24:54"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodanie Biblioteki Angular-jwt",
                                            Duration = "00:24:54"
                                        },
                                        new Lesson
                                        {
                                            Name = "Rozkodowanie Tokena",
                                            Duration = "00:20:09"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Portal Randkowy",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Rozszerzamy Klasę Użytkownik",
                                            Duration = "00:17:45"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodanie Migracji Uaktualnienie Bazy Danych",
                                            Duration = "00:19:31"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dane Testowe",
                                            Duration = "00:37:12"
                                        },
                                        new Lesson
                                        {
                                            Name = "Ładowanie Danych Testowych do Bazy Danych",
                                            Duration = "00:23:58"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodanie GenericRepository I UserRepository",
                                            Duration = "00:27:28"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodanie UserController",
                                            Duration = "00:30:23"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodanie Dto",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "AutoMapper",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "AutoMapper Mapowanie",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodajemy Model Do Naszej Aplikacji SPA",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodajemy User Service",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodajemy Component User List",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodanie Routingu",
                                            Duration = "00:37:12"
                                        },
                                        new Lesson
                                        {
                                            Name = "Ustawiamy Linki Nawigacyjne",
                                            Duration = "00:23:58"
                                        },
                                        new Lesson
                                        {
                                            Name = "Przekierowanie Do Wybranej Strony",
                                            Duration = "00:27:28"
                                        },
                                        new Lesson
                                        {
                                            Name = "Zabezpieczenie Routingu",
                                            Duration = "00:30:23"
                                        },
                                        new Lesson
                                        {
                                            Name = "Zabezpieczenie Routingu cz.2",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodanie Ngx Bootstrap",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodanie Bootswatch",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Obsługa Błędów W API",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Obsługa Błędów W API cz.2",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Obsługa Błędów Angular",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodanie Komponentu Karta Użytkownika",
                                            Duration = "00:37:12"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodajemy Przyciski Do Karty Użytkownika",
                                            Duration = "00:23:58"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodajemy Banery Reklamowe",
                                            Duration = "00:27:28"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodanie Komponentu Szczegóły Użytkownika",
                                            Duration = "00:30:23"
                                        },
                                        new Lesson
                                        {
                                            Name = "Szczegóły Użytkownika Szablon",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Szczegóły Użytkownika Zakładki",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Szczegóły Użytkownika Zakładki Stylowanie",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Route Resolvers",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Galeria Zdjęć",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Edycja Użytkownika Dodanie Komponentu",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Edycja Użytkownika Przygotowanie Szablonu",
                                            Duration = "00:37:12"
                                        },
                                        new Lesson
                                        {
                                            Name = "Edycja Użytkownika Modyfikujemy Szablon",
                                            Duration = "00:23:58"
                                        },
                                        new Lesson
                                        {
                                            Name = "Edycja Użytkownika Zapobiegamy Utracie Nie Zapisanych Danych",
                                            Duration = "00:27:28"
                                        },
                                        new Lesson
                                        {
                                            Name = "Edycja Użytkownika API",
                                            Duration = "00:30:23"
                                        },
                                        new Lesson
                                        {
                                            Name = "Edycja Użytkownika Wykorzystanie API",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Claudinary Konfiguracja.",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodajemy Kontroler Zdjęć",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Kontroler Zdjęć Modyfikacje",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Testujemy Dodawanie Zdjęcia W Postmanie",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Angular Dodajemy Komponent Zdjęcia",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodanie Zewnętrznengo Komponentu Do Przesyłania Plików",
                                            Duration = "00:37:12"
                                        },
                                        new Lesson
                                        {
                                            Name = "Konfiguracja Stylizacja Komponentu Do Zdjęć",
                                            Duration = "00:23:58"
                                        },
                                        new Lesson
                                        {
                                            Name = "Ustawiamy Zdjęcie Główne API",
                                            Duration = "00:27:28"
                                        },
                                        new Lesson
                                        {
                                            Name = "Ustawiamy Zdjęcie Główne SPA",
                                            Duration = "00:30:23"
                                        },
                                        new Lesson
                                        {
                                            Name = "Ustawiamy Zdjęcie Główne Dodajemy Właściwość @Output",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodajemy Zdjecie Główne Do Nawigacji",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Użycie BehaviorSubject",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Usuwanie Zdjęcia API",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Usuwanie Zdjęcia SPA",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Reactive Forms",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Walidacja",
                                            Duration = "00:37:12"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodajemy Nasz Własny Walidator",
                                            Duration = "00:23:58"
                                        },
                                        new Lesson
                                        {
                                            Name = "Wyświetlanie Komunikatów Walidacyjnych Użytkownikowi",
                                            Duration = "00:27:28"
                                        },
                                        new Lesson
                                        {
                                            Name = "FromBuilder Service",
                                            Duration = "00:30:23"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodajemy Dodatkowe Pola Do Formularza",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Użycie Datepicker",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Uaktualnienie Metody Rejestracji W API",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dokończenie Rejestracji W Naszej Aplikacji SPA",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Poprawki Z Domyślnym Zdjęciem Użytkownika",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Wyświetlanie Daty",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Ostatnia Aktywność Action Filtr",
                                            Duration = "00:37:12"
                                        },
                                        new Lesson
                                        {
                                            Name = "Stronnicowanie Dodanie PagedList",
                                            Duration = "00:23:58"
                                        },
                                        new Lesson
                                        {
                                            Name = "Stronnicowanie Pagination Helper",
                                            Duration = "00:27:28"
                                        },
                                        new Lesson
                                        {
                                            Name = "Stronnicowanie Implementacja W API",
                                            Duration = "00:30:23"
                                        },
                                        new Lesson
                                        {
                                            Name = "Stronnicowanie Ngx Bootstrap Pagination",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "API Filtrowanie",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "SPA Filtrowanie",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "API Sortowanie",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "SPA Sortowanie",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodanie Klasy Like",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodanie Funkcjonalności Polubień Do API",
                                            Duration = "00:37:12"
                                        },
                                        new Lesson
                                        {
                                            Name = "Pobieranie Listy Użytkowników Lubiących I Lubianych Przez Użytkownika",
                                            Duration = "00:23:58"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodanie Funkcjonalnosci Polubień Do SPA",
                                            Duration = "00:27:28"
                                        },
                                        new Lesson
                                        {
                                            Name = "Implementacja Komponentu Polubienia SPA",
                                            Duration = "00:30:23"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodajemy Klase Wiadomości",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodanie Metod Do Repozytorium Dla Wiadomości",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodanie Kontrolera Wiadomości",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Implementacja Metody W Repozytorium Dla Skrzynki Nadawczej I Odbiorczej",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Implementacja Metody GetMessagesForUser W Kontrolerze",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Pobieranie Konwersacji 2 Użytkowników",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Message Component",
                                            Duration = "00:37:12"
                                        },
                                        new Lesson
                                        {
                                            Name = "Message Component Szablon",
                                            Duration = "00:23:58"
                                        },
                                        new Lesson
                                        {
                                            Name = "User Messages Component",
                                            Duration = "00:27:28"
                                        },
                                        new Lesson
                                        {
                                            Name = "User Messages Component Wygląd",
                                            Duration = "00:30:23"
                                        },
                                        new Lesson
                                        {
                                            Name = "Messages Query Params",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Wysyłanie Wiadomości",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Rozwiazanie Problemu",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Usuwanie Wiadomości API",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Usuwanie Wiadomości SPA",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Poprawka Wiadomosci",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Przeczytana Wiadomosc",
                                            Duration = "00:37:12"
                                        },
                                        new Lesson
                                        {
                                            Name = "Poprawka Rejestracja Polubienia",
                                            Duration = "00:23:58"
                                        },
                                        new Lesson
                                        {
                                            Name = "Poprawka Polubienia",
                                            Duration = "00:27:28"
                                        },
                                        new Lesson
                                        {
                                            Name = "Ng build",
                                            Duration = "00:30:23"
                                        },
                                        new Lesson
                                        {
                                            Name = "Ng build –prod",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Instalacja MySql",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Dodanie Dostawcy Do MySql",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Przechodzimy Na Baze MySql",
                                            Duration = "00:21:33"
                                        },
                                        new Lesson
                                        {
                                            Name = "Publikujemy Strone Na IIS",
                                            Duration = "00:21:33"
                                        }
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Z Całkiem Innej Beczki",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Canva",
                                            Duration = "00:16:11"
                                        },
                                        new Lesson
                                        {
                                            Name = "Nozbe",
                                            Duration = "00:18:28"
                                        },
                                        new Lesson
                                        {
                                            Name = "Evernote",
                                            Duration = "00:12:26"
                                        },
                                        new Lesson
                                        {
                                            Name = "Generator Kalendarzy",
                                            Duration = "00:06:58"
                                        },
                                        new Lesson
                                        {
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
                            Question = "Często zadawane pytanie",
                            Answer = "Odpowiedz na pierwszr czesto zadawane pytanie"
                        }
                    },
                    Announcements = new List<Announcement>
                    {
                        new Announcement
                        {
                            Content = "Kod źródłowy dostępny na githubie : https://github.com/mariuszjurczenko/PortalRandkowy"
                        }
                    },
                    Opinions = new List<Opinion>
                    {
                        new Opinion
                        {
                            Content = "Bardzo ciekawy kurs. Zwięźle i rzeczowo. Poza niezaprzeczalną dawką wiedzy, można znaleźć w nim również całkiem sporo motywacji do działania :) Polecam",
                            NumberOfStars = 5
                        },
                        new Opinion
                        {
                            Content = "Kurs dobry zwykle poszczególne kroki są przystępnie wytłumaczone. Ogólnie polecam z odrobiną wysiłku udało mi się skończyć projekt w .Net Core 3.1 oraz Angular 8",
                            NumberOfStars = 5
                        },
                    },
                    Category = Categories["PRAKTYCZNE PROJEKTY"]
                },
                new Course
                {
                    Name = "Asp.Net MVC Praktyczny Kurs",
                    Author = "Mariusz Jurczenko",
                    Price = 100,
                    ImageUrl = "https://dev-hobby.pl/wordpress/wp-content/uploads/2020/09/Sklep-Internetowy.png",
                    ImageThumbnailUrl = "https://dev-hobby.pl/wordpress/wp-content/uploads/2020/09/Sklep-Internetowy-300x169.png",
                    IsCourseOfTheMonth = false,
                    IsRecommended = false,
                    Description = new Description
                    {
                        Name = "Asp.Net MVC Praktyczny Kurs – Aplikacja Sklepu Internetowego",
                        WhatWillYouLearn = new List<WhatWillYouLearn>
                        {
                            new WhatWillYouLearn
                            {
                                Content = "ASP NET MVC"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Entity Framework i podejście code first"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Inicjalizowania bazy danych"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Mechanizm migracji"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Glimps"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Cache"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Wywołań asynchronicznych AJAX"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Logowania i rejestracji użytkowników"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Mechanizm koszyka"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Elmach i Nlog"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Postal"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Hangfire"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Kontener DI (Dependency Injection)"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "LocalDb"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Wersjonowania kodu Git"
                            },
                            new WhatWillYouLearn
                            {
                                Content = "Zarządzania projektem VisualStudio Online"
                            }
                        },
                        Requirements = new List<Requirement>
                        {
                            new Requirement
                            {
                                Content = "Podstawowa znajomość C#"
                            }
                        },
                        WhoIsThisCourseFor = new List<WhoIsThisCourseFor>
                        {
                            new WhoIsThisCourseFor
                            {
                                Content = "Początkujący programiści ASP NET MVC"
                            },
                            new WhoIsThisCourseFor
                            {
                                Content = "Początkujący programiści C#"
                            },
                            new WhoIsThisCourseFor
                            {
                                Content = "Wszyscy chętni do dobrej zabawy z kodowaniem"
                            }
                        },
                        Content = "Pokażę praktyczne zastosowanie technologii ASP.NET MVC. Zbuduję w pełni funkcjonalny sklep internetowy. W kursie będziemy korzystać z Visual Studio Comunity oraz wbudowanej bazy danych localDb. Skorzystamy również z systemu do wersjonowania kodu i zarządzania projektem VisualStudio Online, będziemy korzystać z Gita. Następnie dodamy Makietę – prototyp aplikacji do naszego projektu, wyodrębnimy części wspólne widoków do tzw. layoutu. Dodamy strony statyczne do naszej aplikacji. Dodamy trasy dla stron statycznych. Zainstalujemy Glimpsa. Oprogramujemy stronę główną naszej aplikacji, oprogramujemy stronę z kursami w wybranej kategorii, zrobimy widok pojedynczego kursu. Dodamy scieżkę nawigacyjną, dodamy Cache, pokażę jak zrealizować mechanizm filtrowania kursów oraz autopodpowiedzi przy użyciu javaScriptu i wywołań  asynchronicznych AJAX, oraz wykorzystamy JSONa. Zaimplementujemy mechanizm koszyka. Zrobimy widoki logowania i rejestracji użytkowników. Te 2 widoki będą oparte o bardzo podobna strukturę do widoku koszyka na zakupy który już zrobiliśmy. Do naszych widoków rejestracja użytkowników i logowanie użytkowników dodamy mechanizmy obsługujące logikę rejestracji  użytkowników i logowania użytkowników, i skorzystamy tutaj z gotowych wbudowanych mechanizmów w ASP dot net MVC takich jak  ASPNET identity.",
                    },
                    CourseContent = new List<Content>
                    {
                        new Content
                        {
                            Chapters = new List<Chapter>
                            {
                                new Chapter
                                {
                                    Name = "Aplikacja Sklepu Internetowego",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Lekcja 1",
                                            Duration = "00:05:12"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 2",
                                            Duration = "00:10:32"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 3",
                                            Duration = "00:20:13"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 4",
                                            Duration = "00:26:37"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 5",
                                            Duration = "00:05:12"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 6",
                                            Duration = "00:10:32"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 7",
                                            Duration = "00:10:32"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 8",
                                            Duration = "00:10:32"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 9",
                                            Duration = "00:10:32"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 10",
                                            Duration = "00:26:37"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 11",
                                            Duration = "00:26:37"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 12",
                                            Duration = "00:26:37"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 13",
                                            Duration = "00:26:37"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 14",
                                            Duration = "00:26:37"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 15",
                                            Duration = "00:05:12"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 16",
                                            Duration = "00:10:32"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 17",
                                            Duration = "00:10:32"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 18",
                                            Duration = "00:10:32"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 19",
                                            Duration = "00:10:32"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 20",
                                            Duration = "00:26:37"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 21",
                                            Duration = "00:26:37"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 22",
                                            Duration = "00:26:37"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 23",
                                            Duration = "00:26:37"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 24",
                                            Duration = "00:26:37"
                                        },
                                        new Lesson
                                        {
                                            Name = "Lekcja 25",
                                            Duration = "00:05:12"
                                        },
                                    }
                                },
                                new Chapter
                                {
                                    Name = "Z Całkiem Innej Beczki",
                                    Lessons = new List<Lesson>
                                    {
                                        new Lesson
                                        {
                                            Name = "Canva",
                                            Duration = "00:16:11"
                                        },
                                        new Lesson
                                        {
                                            Name = "Nozbe",
                                            Duration = "00:18:28"
                                        },
                                        new Lesson
                                        {
                                            Name = "Evernote",
                                            Duration = "00:12:26"
                                        },
                                        new Lesson
                                        {
                                            Name = "Generator Kalendarzy",
                                            Duration = "00:06:58"
                                        },
                                        new Lesson
                                        {
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
                            Question = "Pytanie 1",
                            Answer = "Odpowiedz na często zadawane pytanie"
                        }
                    },
                    Announcements = new List<Announcement>
                    {
                        new Announcement
                        {
                            Content = "Kod źródłowy dostępny na githubie : https://github.com/mariuszjurczenko/SklepAspNetMvc"
                        }
                    },
                    Opinions = new List<Opinion>
                    {
                        new Opinion
                        {
                            Content = "Bardzo ciekawy kurs. Zwięźle i rzeczowo. Polecam",
                            NumberOfStars = 5
                        }
                    },
                    Category = Categories["PRAKTYCZNE PROJEKTY"]
                }
            );
        }

        devHobbyDbContext.SaveChanges();
    }

    private static Dictionary<string, Category>? categories;

    public static Dictionary<string, Category> Categories
    {
        get
        {
            if (categories == null)
            {
                var categoryList = new Category[]
                {
                    new Category { Name = "CSHARP" },
                    new Category { Name = "ASP NET CORE" },
                    new Category { Name = "CMS" },
                    new Category { Name = "DOBRE PRAKTYKI"},
                    new Category { Name = "PRAKTYCZNE PROJEKTY" },
                    new Category { Name = "JAVA SCRIPT" },
                    new Category { Name = "ANGULAR" }
                };

                categories = new Dictionary<string, Category>();

                foreach (Category category in categoryList)
                {
                    categories.Add(category.Name, category);
                }
            }

            return categories;
        }
    }
}