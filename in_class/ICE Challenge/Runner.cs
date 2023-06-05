public class Runner{
    public int GetFloor(Elevator currentObject){
        return currentObject./*returning floor unmber function*/
    }
    public void RequestFloor(Elevator currentObject, int floor){
        if(currentObject./*name of return floor availability function*/){
            MoveToFloor(currentObject, floor);
        }
    }
    private void MoveToFloor(Elevator currentObject, int floorNumber){
        currentObject./*function for setting floor variable*/(floorNumber);
    }
    public void DisplayFloor(Elevator currentObject){
        Console.WriteLine($"Current Floor: {GetFloor(currentObject)}");
    }
    public void DisplayAvailableFloors(Elevator currentObject){
        
        Console.WriteLine($"{currentObject./*GetList function*/}");
    }
    public void OpenCloseDoor(Elevator currentObject, string userInput){
        userInput.ToUpper();
        if(!currentObject.GetOpen()){
            if(userInput=="OPEN"){
                currentObject.OpenDoors();
            }
        }else{
            if(userInput=="CLOSE"){
                currentObject.CloseDoors();
            }
        }
    }


}