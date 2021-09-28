using System;

//string t = "v";
//bool isAlive = true;

//Console.Writeline(t == "V");

Console.WriteLine("höger eller vänster");
string vart = Console.ReadLine();


if (vart == "höger")
{
    Console.WriteLine("Kapten vi blir anfallna ryssarna kommer att inta denna posistion vilken moment som helst ska vi fly eller stoppa dom");

    string vad = Console.ReadLine();
    if (vad == "fly")
    {
        Console.WriteLine("du och dina män hoppar ur era skyttegravar och börjar springa mot skogen. män faller höger och vänster om dig du hinner inte ens kolla. du kommer fram till skogen men ser att bara 3 män är kvar ska du anfalla på nattten eller counter attack");
        string attack = Console.ReadLine();
        if (attack == "anfalla på natten")
        {
            Console.WriteLine("du smyger upp till dina gamla skyttegravar där ryssarna nu håller sig i, och hoppar in med kniv i handen så neutraliserar 3 ryssar innan du blir skjuten på bollarna sen avrättad");
        }
        else if (attack == "counter attack")
        {
            Console.WriteLine("du och dina 3 män heroiskt springer över fältet mot era skyttegraver som ni have fegt övergett bara för att dö halvvägs dit och bli känd som den sämsta officeraren i världen");
        }
        else
        {
            Console.WriteLine("du och dina män springer ifrån slagfältet men senare blir hittade, fängslade och sen avrättade för er feghet");
        }



    }
    else if (vad == "stoppa dom")
    {
        Console.WriteLine("du och dina män håller emot de många ryssarna med era kulsprutor och granater men du blir dödligt skadad av ett skot i bröstet. du fallner ner i skyttegraven och du ser en av dina män över dig medans ljudet blir svagare och allting blir mörkare runt omkring dig");
    }
    else
    {
        Console.WriteLine("du är shell shocked och kan inte göra någoting du blir sjkuten och dör");

    }
}
else if (vart == "vänster")
{
    Console.WriteLine("Bravo six the enemy has the hostages in the room should we breach or send in a negosiator");
}
else
{
    Console.WriteLine("you did not say vänster or höger and will now spend the rest of your existance in the femboy room Glory to Horistanska");
}











Console.ReadLine();

