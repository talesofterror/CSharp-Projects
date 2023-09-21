public class Player : Entity {
    public Player(string _name, string _role, int _healthMax, int _healthStatus) 
    : base(_name, _role, _healthMax, _healthStatus)
  {
    name = _name;
    role = _role;
    healthMax = _healthMax;
    healthStatus = _healthStatus;
  }
}