using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;

namespace GiftsForEveryone.Models
{

    public static class SeedData
    {

        public static void EnsurePopulated(IServiceProvider services)
        {
            ApplicationDbContext context = services.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                //valentine's day
                new Product
                {
                    Name = "Half Heart Square Red Mug Set",
                    Description = "A Personal Creations Exclusive! When placed together, our unique square mugs form one big heart. A cute way to share your morning coffee.",
                    Category = "VALENTINE'S DAY GIFTS",
                    Price = 35.99M
                },
                new Product
                {
                    Name = "Family Tree Necklace",
                    Description = "This handmade, personalized birthstone necklace with engraved name charms will make for a perfect gift for mom.",
                    Category = "VALENTINE'S DAY GIFTS",
                    Price = 38
                },
                new Product
                {
                    Name = "Thursday Finest Merino Wool Socks",
                    Description = "The Woolmark Company has partnered with Brooklyn Based brand Thursday Finest to deliver a line of totally awesome customizable socks perfect for showing your V-Day love!",
                    Category = "VALENTINE'S DAY GIFTS",
                    Price = 30
                },
                new Product
                {
                    Name = "The Original Boyfriend Pillow",
                    Description = "With this pillow by your side, you will never have to miss your special guy again.",
                    Category = "VALENTINE'S DAY GIFTS",
                    Price = 35
                },
                new Product
                {
                    Name = "Hot Lips Bean Bag Chair",
                    Description = "Pucker up and relax in this Fun Factory Hot Lips Fun Shapes Bean Bag.",
                    Category = "VALENTINE'S DAY GIFTS",
                    Price = 57
                },
                new Product
                {
                    Name = "Personalized Heart Initial Necklace",
                    Description = "There is nothing like a personalized heart necklace to make someone feel special — even if is (very) last-minute!",
                    Category = "VALENTINE'S DAY GIFTS",
                    Price = 16
                },
                new Product
                {
                    Name = "Club Champ Kooler Klub Drink Dispenser",
                    Description = "Golf and drinking go hand-in-hand! With this funny little device, your love can sneak drinks on the course without anyone knowing.",
                    Category = "VALENTINE'S DAY GIFTS",
                    Price = 39
                },
                new Product
                {
                    Name = "Monogram 12-Bottle Beer Cooler",
                    Description = "Invite them on a romantic picnic and surprise them with 12 cold ones in this army green cooler with their initial on it.",
                    Category = "VALENTINE'S DAY GIFTS",
                    Price = 48
                },
                new Product
                {
                    Name = "Ultimate Ears Wonderboom Portable Waterproof Bluetooth",
                    Description = "When it come to gifts, these Wonderboom portable waterproof speakers are a Valentine's Day crowd-pleaser. ",
                    Category = "VALENTINE'S DAY GIFTS",
                    Price = 80
                },
                new Product
                {
                    Name = "Soap Flower Bathing Petals",
                    Description = "If you loved one loves to take bath, gift them with a different kind of flower bouquet this year",
                    Category = "VALENTINE'S DAY GIFTS",
                    Price = 20
                },

                //bday
                new Product
                {
                    Name = "Birthday Brights™ Bouquet",
                    Description = "The Birthday Brights™ Bouquet is a true celebration of color and life to surprise and delight your special recipient on their big day!",
                    Category = "BIRTHDAY GIFTS",
                    Price = 70
                },
                new Product
                {
                    Name = "Personalized Teacher Mug",
                    Description = "Not only is this mug personalized, but it's hilarious too.",
                    Category = "BIRTHDAY GIFTS",
                    Price = 29.50M
                },
                new Product
                {
                    Name = "Custom Teacher Gift",
                    Description = "This stamp will come in handy for years to come",
                    Category = "BIRTHDAY GIFTS",
                    Price = 44.10M
                },
                new Product
                {
                    Name = "Teach, Love, Inspire Bracelet",
                    Description = "On the inner side, you can add your favorite teacher's name.",
                    Category = "BIRTHDAY GIFTS",
                    Price = 16.00M
                },
                new Product
                {
                    Name = "The Jolly Christmas Postman",
                    Description = "Kids will delight in all the hidden surprises, puzzles, and other interactive elements The Jolly Christmas Postman has to offer.",
                    Category = "BIRTHDAY GIFTS",
                    Price = 11.59M
                },
                new Product
                {
                    Name = "Christmas in the Manger Book",
                    Description = "The nativity comes to life in this popular buy, which now comes as a board book.",
                    Category = "BIRTHDAY GIFTS",
                    Price = 6.54M
                },
                new Product
                {
                    Name = "Pete the Cat Saves Christmas. Age range: 4-8 years ",
                    Description = "Pete is the coolest cat around, and he’s ready to celebrate the holidays with your little ones.",
                    Category = "BIRTHDAY GIFTS",
                    Price = 9.79M
                },
                new Product
                {
                    Name = "Yoda Best Boss Mug",
                    Description = "Then he or she will love this relevant mug.",
                    Category = "BIRTHDAY GIFTS",
                    Price = 19.95M
                },
                new Product
                {
                    Name = "Favorite Employee Wine Label",
                    Description = "'From your favorite employee' is the hilarious phrase imprinted on this wine bottle label.",
                    Category = "BIRTHDAY GIFTS",
                    Price = 5.50M
                },
                new Product
                {
                    Name = "Wishes to your boss",
                    Description = "Good wishes to your boss, that will make him smile.",
                    Category = "BIRTHDAY GIFTS",
                    Price = 5.50M
                },


                //xmas/new year
                new Product
                {
                    Name = "Glass Bottle With Glowing Lights Inside",
                    Description = "Bring home this magnificent piece of decor and give your home an illuminating effect. ",
                    Category = "CHRISTMAS NEW YEAR GIFTS",
                    Price = 17.93M
                },
                new Product
                {
                    Name = "Zyllion Shiatsu Back Neck Massager",
                    Description = "This sleek neck massager has more than 8,000 rave reviews on Amazon and it's no wonder why.",
                    Category = "CHRISTMAS NEW YEAR GIFTS",
                    Price = 31.95M
                },
                new Product
                {
                    Name = "SoundBot Bluetooth Wireless Smart Beanie Headset",
                    Description = "This cozy beanie has built-in Bluetooth speakers to make listening to music a way more efficient process on chilly days.",
                    Category = "CHRISTMAS NEW YEAR GIFTS",
                    Price = 19.99M
                },
                new Product
                {
                    Name = "You Are a Badass 2020 Day-to-Day Calendar",
                    Description = "For anyone who needs a bit of inspro to start their day.",
                    Category = "CHRISTMAS NEW YEAR GIFTS",
                    Price = 10.99M
                },
                new Product
                {
                    Name = "GoWISE 5.8-QT 8-in-1 Digital Air Fryer",
                    Description = "Gift them this popular programmable air fryer so that they can cook up all of their favorite crispy foods without any of the guilt. ",
                    Category = "CHRISTMAS NEW YEAR GIFTS",
                    Price = 58.20M
                },
                new Product
                {
                    Name = "YnM Weighted Blanket",
                    Description = "Help to relax blanket.",
                    Category = "CHRISTMAS NEW YEAR GIFTS",
                    Price = 39.95M
                },
                new Product
                {
                    Name = "Ember Temperature Control Smart Mug",
                    Description = "Keeping tea, coffee, and hot cocoa wasrm has never been easier than with this smart cup.",
                    Category = "CHRISTMAS NEW YEAR GIFTS",
                    Price = 109.95M
                },
                new Product
                {
                    Name = "Intelex Cozy Body Slippers",
                    Description = "Pup these plush puppies into the microwave, and toes will be toasty in no time.",
                    Category = "CHRISTMAS NEW YEAR GIFTS",
                    Price = 25.00M
                },
                new Product
                {
                    Name = "Winc Wine Subscription",
                    Description = "Keep the good times rolling and the vino flowing by giving them a gift credit to Winc.",
                    Category = "CHRISTMAS NEW YEAR GIFTS",
                    Price = 52.29M
                },
                new Product
                {
                    Name = "Relay Kids Screenless Smartphone",
                    Description = "A screen-free, water-resistant,one-touch cell phone altenative.",
                    Category = "CHRISTMAS NEW YEAR GIFTS",
                    Price = 24.99M
                }
                                             

                //new Product
                //{
                //    Name = "Kayak",
                //    Description = "A boat for one person",
                //    Category = "Watersports",
                //    Price = 275
                //},
                //new Product
                //{
                //    Name = "Lifejacket",
                //    Description = "Protective and fashionable",
                //    Category = "Watersports",
                //    Price = 48.95m
                //},
                //new Product
                //{
                //    Name = "Soccer Ball",
                //    Description = "FIFA-approved size and weight",
                //    Category = "Soccer",
                //    Price = 19.50m
                //},
                //new Product
                //{
                //    Name = "Corner Flags",
                //    Description = "Give your playing field a professional touch",
                //    Category = "Soccer",
                //    Price = 34.95m
                //},
                //new Product
                //{
                //    Name = "Stadium",
                //    Description = "Flat-packed 35,000-seat stadium",
                //    Category = "Soccer",
                //    Price = 79500
                //},
                //new Product
                //{
                //    Name = "Thinking Cap",
                //    Description = "Improve brain efficiency by 75%",
                //    Category = "Chess",
                //    Price = 16
                //},
                //new Product
                //{
                //    Name = "Unsteady Chair",
                //    Description = "Secretly give your opponent a disadvantage",
                //    Category = "Chess",
                //    Price = 29.95m
                //},
                //new Product
                //{
                //    Name = "Human Chess Board",
                //    Description = "A fun game for the family",
                //    Category = "Chess",
                //    Price = 75
                //},
                //new Product
                //{
                //    Name = "Bling-Bling King",
                //    Description = "Gold-plated, diamond-studded King",
                //    Category = "Chess",
                //    Price = 1200
                //}
                );
                context.SaveChanges();
            }
        }
    }
}