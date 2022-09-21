using Microsoft.EntityFrameworkCore.Migrations;

namespace Bibliotek_Labb1.Migrations
{
    public partial class AddedSeedDataForImageAndDescriptionProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 1,
                columns: new[] { "Description", "ImageThumbnailUrl" },
                values: new object[] { "In a hole in the ground there lived a hobbit. Not a nasty, dirty, wet hole, filled with the ends of worms and an oozy smell, nor yet a dry, bare, sandy hole with nothing in it to sit down on or to eat: it was a hobbit-hole, and that means comfort.", "\\Images\\TheHobbit1.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 2,
                columns: new[] { "Description", "ImageThumbnailUrl" },
                values: new object[] { "One Ring to rule them all, One Ring to find them, One Ring to bring them all and in the darkeness bind them.In ancient times the Rings of Power were crafted by the Elven - smiths, and Sauron, The Dark Lord, forged the One Ring, filling it with his own power so that he could rule all others.But the One Ring was taken from him, and though he sought it throughout Middle - earth, it remained lost to him.After many ages it fell into the hands of Bilbo Baggins, as told in The Hobbit.In a sleepy village in the Shire, young Frodo Baggins finds himself faced with an immense task, as his elderly cousin Bilbo entrusts the Ring to his care.Frodo must leave his home and make a perilous journey across Middle - earth to the Cracks of Doom,there to destroy the Ring and foil the Dark Lord in his evil purpose.", "\\Images\\TheFellowshipOfTheRing1.gif" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 3,
                columns: new[] { "Description", "ImageThumbnailUrl" },
                values: new object[] { "One Ring to rule them all, One Ring to find them, One Ring to bring them all and in the darkness bind them.Frodo and his Companions of the Ring have been beset by danger during their quest to prevent the Ruling Ring from falling into the hands of the Dark Lord by destroying it in the Cracks of Doom. They have lost the wizard, Gandalf, in a battle in the Mines of Moria. And Boromir, seduced by the power of the Ring, tried to seize it by force. While Frodo and Sam made their escape, the rest of the company was attacked by Orcs. Now they continue the journey alone down the great River Anduin—alone, that is, save for the mysterious creeping figure that follows wherever they go.", "\\Images\\TheTwoTowers1.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 4,
                columns: new[] { "Description", "ImageThumbnailUrl" },
                values: new object[] { "One Ring to rule them all, One Ring to find them, One Ring to bring them all and in the darkness bind them.The Dark Lord has risen, and as he unleashes hordes of Orcs to conquer all Middle-earth, Frodo and Sam struggle deep into his realm in Mordor. To defeat Sauron, the One Ring must be destroyed in the fires of Mount Doom. But the way is impossibly hard, and Frodo is weakening. The Ring corrupts all who bear it and Frodo’s time is running out. Will Sam and Frodo succeed, or will the Dark Lord rule Middle-earth once more? ", "\\Images\\TheReturnOfTheKing.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 5,
                columns: new[] { "Description", "ImageThumbnailUrl" },
                values: new object[] { "Scout, the keen-eyed narrator, and her brother Jem interrupt their games to champion their lawyer father when, in a hostile, racist town in the American South, he battles to defend Tom, who is black and accused of murder.", "\\Images\\ToKillAMockingBird1.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 6,
                columns: new[] { "Description", "ImageThumbnailUrl" },
                values: new object[] { "'It was one of those rare smiles with a quality of eternal reassurance in it, that you may come across four or five times in life'Jay Gatsby is the man who has everything. But one thing will always be out of his reach ... Everybody who is anybody is seen at his glittering parties. Day and night his Long Island mansion buzzes with bright young things drinking, dancing and debating his mysterious character. For Gatsby - young, handsome, fabulously rich - always seems alone in the crowd, watching and waiting, though no one knows what for. Beneath the shimmering surface of his life he is hiding a secret: a silent longing that can never be fulfilled. And soon this destructive obsession will force his world to unravel.", "\\Images\\TheGreatGatsby1.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 7,
                columns: new[] { "Description", "ImageThumbnailUrl" },
                values: new object[] { "The story of the orphan Oliver, who runs away from the workhouse only to be taken in by a den of thieves, shocked readers when it was first published. Dickens's tale of childhood innocence beset by evil depicts the dark criminal underworld of a London peopled by vivid and memorable characters - the arch-villain Fagin, the artful Dodger, the menacing Bill Sikes and the prostitute Nancy. Combining elements of Gothic Romance, the Newgate Novel and popular melodrama, Dickens created an entirely new kind of fiction, scathing in its indictment of a cruel society, and pervaded by an unforgettable sense of threat and mystery.", "\\Images\\OliverTwist1.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 8,
                columns: new[] { "Description", "ImageThumbnailUrl" },
                values: new object[] { "Obsessed by creating life itself, Victor Frankenstein plunders graveyards for the material to fashion a new being, which he shocks into life by electricity. But his botched creature, rejected by Frankenstein and denied human companionship, sets out to destroy his maker and all that he holds dear. ", "\\Images\\Frankenstein1.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 9,
                columns: new[] { "Description", "ImageThumbnailUrl" },
                values: new object[] { "In a house haunted by memories, the past is everywhere … As darkness falls, a man caught in a snowstorm is forced to shelter at the strange, grim house Wuthering Heights. It is a place he will never forget. There he will come to learn the story of Cathy: how she was forced to choose between her well-meaning husband and the dangerous man she had loved since she was young. How her choice led to betrayal and terrible revenge - and continues to torment those in the present. How love can transgress authority, convention, even death. And how desire can kill.", "\\Images\\WutheringHeights1.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 10,
                columns: new[] { "Description", "ImageThumbnailUrl" },
                values: new object[] { "In Herman Melville's Moby-Dick, Captain Ahab is an eerily compelling madman who focuses his distilled hatred and suffering (and that of generations before him) into the pursuit of a creature as vast, dangerous and unknowable as the sea itself. More than just a novel of adventure, this is a haunting social commentary populated with some of the most enduring characters in literature. Written with wonderfully redemptive humour, Moby Dick is a profound and timeless inquiry into character, faith and the nature of perception.", "\\Images\\MobyDick1.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 11,
                columns: new[] { "Description", "ImageThumbnailUrl" },
                values: new object[] { "Macon Dead, Jr., called 'Milkman,'the son of the wealthiest African American in town, moves from childhood into early manhood, searching, among the disparate, mysterious members of his family, for his life and reality. ", "\\Images\\SongOfSolomon.jpeg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 1,
                columns: new[] { "Description", "ImageThumbnailUrl" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 2,
                columns: new[] { "Description", "ImageThumbnailUrl" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 3,
                columns: new[] { "Description", "ImageThumbnailUrl" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 4,
                columns: new[] { "Description", "ImageThumbnailUrl" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 5,
                columns: new[] { "Description", "ImageThumbnailUrl" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 6,
                columns: new[] { "Description", "ImageThumbnailUrl" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 7,
                columns: new[] { "Description", "ImageThumbnailUrl" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 8,
                columns: new[] { "Description", "ImageThumbnailUrl" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 9,
                columns: new[] { "Description", "ImageThumbnailUrl" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 10,
                columns: new[] { "Description", "ImageThumbnailUrl" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 11,
                columns: new[] { "Description", "ImageThumbnailUrl" },
                values: new object[] { null, null });
        }
    }
}
