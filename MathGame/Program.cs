// See https://aka.ms/new-console-template for more information

using MathGame;

var name = Helpers.GetName();   //sets userName
var menu = new Menu();  // Creates a new menu instance
menu.ShowMenu(name);   //initates menu with userName

