public class Room{
    private int _roomNumber;
    private List<Reservation> _reservations = new List<Reservation>();

    public Room(int roomNumber, List<Reservation> activeReservations){
        _roomNumber=roomNumber;
        _reservations=activeReservations;
    }
    public bool IsAvailable(reservation){
        if(/*compare the reservation time to the other reservations, allow if it makes sense*/){
            return true;
        }else{
            return false;
        }
    }
    public int GetRoomNumber(){return _roomNumber;}

}