using System;

class Program
{
    static void Main(string[] args)
    {
        ScriptureHandler scriptRef = new ScriptureHandler("ScriptureList.txt");
        Menu menu = new Menu(scriptRef.ReturnRef(), scriptRef.ReturnScript());
        bool exit=false;
        while(exit!=true){
            string respo = menu.WaitOnResponse();
            if(respo=="h"){
                Random rand = new Random();
                for(int i = 0; i<rand.Next(1,4); i++){
                    scriptRef.HideWord();
                }
                menu.UpdateScreen(scriptRef.ReturnRef(), scriptRef.ReturnScript());
            }else if(respo=="r"){
                scriptRef.RevealLastWord();
                menu.UpdateScreen(scriptRef.ReturnRef(), scriptRef.ReturnScript());
            }else if(respo=="err"){
                menu.UpdateScreen(scriptRef.ReturnRef(), scriptRef.ReturnScript());
            }else if(respo=="e"){
                exit=true;
            }
        }
    }
}