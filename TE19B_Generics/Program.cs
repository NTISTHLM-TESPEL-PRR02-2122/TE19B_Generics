using System;
using System.Collections.Generic;


Queue<string> orders = new Queue<string>();

orders.Enqueue("walk");
orders.Enqueue("stand");
orders.Enqueue("jump");
orders.Enqueue("lie down");


while (orders.Count > 0)
{
  string o = orders.Dequeue();
  Console.WriteLine(o);

  orders.Enqueue(o);

  Console.ReadLine();
}



// static void Hello()
// {
//   Console.WriteLine("HELLO");
// }

// static void Goodbye()
// {
//   Console.WriteLine("GOODBYE");
// }

// Dictionary<string, Action> actions = new Dictionary<string, Action>();

// actions.Add("hi", Hello);
// actions.Add("bye", Goodbye);

// actions.Add("morning", () =>
// {
//   Console.WriteLine("Good morning!");
// });

// actions["morning"]();

// actions["hi"]();
// actions["hi"]();

// Action h = Hello;

// h();



// List<string> names = new List<string>();
// names.Add("Micke");

// Dictionary<string, string> ordbok = new Dictionary<string, string>();

// ordbok.Add("Micke", "Lärare");
// Console.WriteLine(ordbok["Micke"]);

// ordbok["Micke"] = "Förstelärare";

// // Dictionary<string, Ball> balls = new Dictionary<string, Ball>();

// Dictionary<Ball, string> ballReviews = new Dictionary<Ball, string>();

// Ball b1 = new Ball() {radius = 5};
// Ball b2 = new Ball() {radius = 15};

// ballReviews.Add(b1, "Liten och fin");
// ballReviews.Add(new Ball() {radius = 7}, "Lagom!");

// Console.WriteLine(ballReviews[b1]);






Console.ReadLine();
