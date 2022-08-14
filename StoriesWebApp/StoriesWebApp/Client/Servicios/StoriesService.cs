﻿using StoriesWebApp.Shared;

namespace StoriesWebApp.Client.Servicios
{
    public class StoriesService : IStoriesService
    {
        public enum NoveltiesScope
        {
            today, week, month
        }
        public List<Story> GetNovelties(NoveltiesScope scope)
        {
            var items = new List<Story>
            {
                new Story { Id=1, Title = "Los ángulos tienen dientes", Author = "Eva Artés", PublishedDate = new DateTime(2021, 2, 28, 13, 22, 51), Category = "terror" },
                new Story { Id=2, Title = "La gasolinera", Author = "Raquel Sastre", PublishedDate = new DateTime(2021, 2, 28, 14, 22, 51), Category = "novela" },
                new Story { Id=3, Title = "Dejad que los niños se acerquen a mí", Author = "Andrés López", PublishedDate = new DateTime(2021, 2, 28, 15, 22, 51), Category = "terror" },
                new Story { Id=4, Title = "El vuelo al fin del mundo", Author = "Lucía Castillo", PublishedDate = new DateTime(2021, 2, 28, 16, 22, 51), Category = "ciencia ficción" },
                new Story { Id=5, Title = "El tocador de la abuela", Author = "Diego de Salazar", PublishedDate = new DateTime(2021, 2, 28, 17, 22, 51), Category = "novela" },
                new Story { Id=6, Title = "Las cerillas mojadas no sirven para nada", Author = "Daniela Rubio", PublishedDate = new DateTime(2021, 2, 28, 18, 22, 51), Category = "novela" },
                new Story { Id=7, Title = "Sacando las castañas del fuego", Author = "Ricardo Allen", PublishedDate = new DateTime(2021, 2, 28, 19, 22, 51), Category = "ciencia ficción" },
                new Story { Id=8, Title = "Los árboles invisibles", Author = "Núria Azanza", PublishedDate = new DateTime(2021, 2, 28, 20, 22, 51), Category = "novela histórica" },
                new Story { Id=8, Title = "Dirección prohibida", Author = "Blanca Romero", PublishedDate = new DateTime(2021, 2, 28, 21, 22, 51), Category = "novela" },
                new Story { Id=10, Title = "El olor de las margaritas", Author = "Alfonso Tirado", PublishedDate = new DateTime(2021, 2, 28, 22, 22, 51), Category = "romántica" },
                new Story { Id=11, Title = "Planetas sin vida", Author = "Alejandro Carbonell", PublishedDate = new DateTime(2021, 2, 28, 23, 22, 51), Category = "ciencia ficción" },
                new Story { Id=12, Title = "La vacuna", Author = "Ignacio Aguado", PublishedDate = new DateTime(2021, 2, 28, 0, 22, 51), Category = "ciencia ficción" },
                new Story { Id=13, Title = "El master", Author = "Cristóbal Lafuente", PublishedDate = new DateTime(2021, 2, 28, 1, 22, 51), Category = "Thriller" },
                new Story { Id=14, Title = "El desorden de tu ausencia", Author = "Eduardo Préscoli", PublishedDate = new DateTime(2021, 2, 28, 2, 22, 51), Category = "romántica" },
                new Story { Id=15, Title = "Los amigos que fuimos", Author = "Gloria Onrubia", PublishedDate = new DateTime(2021, 2, 28, 3, 22, 51), Category = "ciencia ficción" },
                new Story { Id=16, Title = "Saltando charcos", Author = "Elena Carrión", PublishedDate = new DateTime(2021, 2, 28, 4, 22, 51), Category = "ciencia ficción" },
                new Story { Id=17, Title = "Las garras del hambre", Author = "Jesús Palomo", PublishedDate = new DateTime(2021, 2, 28, 5, 22, 51), Category = "literatura" },
                new Story { Id=18, Title = "El barco de papel", Author = "Daniel Martín", PublishedDate = new DateTime(2021, 2, 28, 5, 22, 51), Category = "Thriller" },
                new Story { Id=19, Title = "Los gatos también ladran", Author = "Rosa Ramos", PublishedDate = new DateTime(2021, 2, 28, 6, 22, 51), Category = "ciencia ficción" },
                new Story { Id=20, Title = "Durmiendo", Author = "Roberto Masip", PublishedDate = new DateTime(2021, 2, 28, 7, 22, 51), Category = "novela" },
                new Story { Id=21, Title = "La mirada vacía", Author = "Juan María Martín", PublishedDate = new DateTime(2021, 2, 28, 8, 22, 51), Category = "ciencia ficción" }
            };

            int i = 22;
            Random rand = new Random();
            while (i < 500)
            {
                var item = items[rand.Next(1, 21)];
                items.Add(new Story
                {
                    Id = i,
                    Author = item.Author,
                    Category = item.Category,
                    PublishedDate = item.PublishedDate,
                    Title = item.Title,
                });
                i++;
            }

            return items;
        }
    }
}
