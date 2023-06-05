public class Elevator
{
    int x = 1;
    List<int> floors = new List<int>();
    private bool _open = false;

    int _floorNumber = 1;

    public void createFloor()
    {
        while(x <= 30)
        {
            foreach (var floor in floors)
            {
                floors.Add(x);
                x = x + 1;
            }
        }
    }
    public int currentFloor(){return _floorNumber;}
    public void Open()
    {
        _open=true;
    }

    public void Close()
    {
        _open=false;
    }
    public bool GetOpen(){return _open;}

    public void moveFloor(int floorNum)
    {
        if(floorNum <= 30)
        {
            _floorNumber = floorNum;
            Open();
        }
    }

    public List<int> ListFloors()
    {
        return floors;
    }
    public bool GetAvailability(int check){if(check<=30){return true;}else{return false;}}


}
