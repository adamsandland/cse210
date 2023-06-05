public class Runner{
    public int GetFloor(Elevator currentObject){
        return currentObject.currentFloor();
    }
    public void RequestFloor(Elevator currentObject, int floor){
        if(currentObject.GetAvailability(floor)){
            MoveToFloor(currentObject, floor);
        }
    }
    private void MoveToFloor(Elevator currentObject, int floorNumber){
        currentObject.moveFloor(floorNumber);
    }
    public void DisplayFloor(Elevator currentObject){
        Console.WriteLine($"Current Floor: {GetFloor(currentObject)}");
    }
    public void DisplayAvailableFloors(Elevator currentObject){
        
        Console.WriteLine($"{currentObject.ListFloors()}");
    }
    public void OpenCloseDoor(Elevator currentObject, string userInput){
        userInput.ToUpper();
        if(!currentObject.GetOpen()){
            if(userInput=="OPEN"){
                currentObject.Open();
            }
        }else{
            if(userInput=="CLOSE"){
                currentObject.Close();
            }
        }
    }


}