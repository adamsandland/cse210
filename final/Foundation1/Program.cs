using System;

class Program
{
    static void Main(string[] args)
    {
        Video num1 = new Video("Can I 100% Every 3D Mario Game in 1 Week?", "Nathaniel Brandy", 2375);
        Video num2 = new Video("Most Powerful Weapons Guide for Tears of the Kingdom", "Austin John Plays", 2611);
        Video num3 = new Video("My Thoughts on Bluey", "TheOdd1sOut", 965);
        Video num4 = new Video("Skyblock: The Great Potato War", "Technoblade", 1104);

        num1.AddComment("I can't imagine how you felt when you realised how much you need to do to complete Odyssey","Patterrz");
        num1.AddComment("Its actually impressive to see how much he was able to restrain himself from quitting the challenge.","Antflam7473");
        num2.AddComment("A new game must be like a fresh adhd medication prescription for Austin, just multiple videos daily, high quality, well research, unmatched. Love the work!","professorsequia7318");
        num2.AddComment("If you want strong fuse items without taking down super strong monsters, I recommend helping fix lurelin village. If you grab some roasted porgys from near a campfire in the village, you can give them to the treasure shop guy to play for free, so you get enough for all three items. It can have good items like black lynel mace and saber horns. I really recommend it.","Allthegarlicbread4008");
        num3.AddComment("The creator of the show went through four years of child psychology just so he can make the best childrens show ever","Addisonandharper");
        num3.AddComment("Fun fact, Bandid (The dad) is a archaeologist (Digs up bones) and Chilli (The mum) is an Airpot Security Guard  (Sniffer Dog). The parents have real life dog trait jobs and its awsome.","_lunala_7694");
        num3.AddComment("I would call it a family show and not a preschool show. Otherwise you covered this show perfectly. This show is a gem and I hope it never gets wrecked.","JNDS.Creates");
        num4.AddComment("YOU ARE THE WORST","imasquidkid");
        num4.AddComment($"“Dad whats a Technoblade?”/n“Sit down son, Im going to tell you a beautiful story”","pixelbanana1061");
        num4.AddComment("These videos are literally my safe corner of YouTube…even in death Techno provides entertainment, laughter, and love through his content","bigfailures");

        num1.DisplayVideoAndContents();
        num2.DisplayVideoAndContents();
        num3.DisplayVideoAndContents();
        num4.DisplayVideoAndContents();

    }
}