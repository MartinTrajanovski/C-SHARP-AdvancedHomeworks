using Newtonsoft.Json;
using SerializingandDeserializingExercise.Models;
using SerializingandDeserializingExercise.Services;
using System;
using System.Collections.Generic;

namespace SerializingandDeserializingExercise
{
    class Program
    {
        public static void PrintData(List<Post> posts)
        {
            foreach (var post in posts)
            {
                if (post.Id < 21)
                {
                    Console.WriteLine($"UserId: {post.UserId}\nId: {post.Id}\nTitle: {post.Title}\nBody: {post.Body}");
                    Console.WriteLine("+++++++++++++++++++++++++++++");
                }
            }
        }
        static void Main(string[] args)
        {
            string url = "https://jsonplaceholder.typicode.com/posts";
            string userResult = HTTPService.GetData(url);

            List<Post> posts = JsonConvert.DeserializeObject<List<Post>>(userResult);

            PrintData(posts);


            Console.ReadLine();
        }
    }
}
