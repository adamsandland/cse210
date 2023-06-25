public class User{
    private int _points;
    private string _name;
    public List<Goal> _UserGoals;
    public User(List<Goal> UserGoals, string name, int points){
        _UserGoals = UserGoals;
        _name=name;
        _points=points;
    }
    public void DisplayPoints(){
        Console.WriteLine($"Your Points: {_points}");
    }
    public void UpdatePoints(int points){
        _points+=points;
    }
    public void removeItem(Goal item){
        _UserGoals.Remove(item);
    }
    public void SetName(String name){
        _name=name;
    }
    public int GetPoints(){ return _points;}
    public string GetName(){ return _name; }
    public List<Goal> GetGoalList(){ return _UserGoals; }
}