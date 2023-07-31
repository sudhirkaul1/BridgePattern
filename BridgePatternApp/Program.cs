// See https://aka.ms/new-console-template for more information
using BridgePatternApp.BookContentProvider;
using BridgePatternApp.BookPublishers;
using BridgePatternApp.Books;

Console.WriteLine("Hello, World!");

IBookContentProvider cp = new AutoBiographyBookContentProvider();
IBookPublisher bp = new AudioBookPublisher();
Book pb = new Book(cp,bp);
pb.Publish();

IBookPublisher dp = new DigitalBookPublisher();
Book db = new Book(cp,dp);
db.Publish();

