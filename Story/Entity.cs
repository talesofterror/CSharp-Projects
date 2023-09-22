public class Entity
{
  public string name;
  public string role;
  public int healthMax;
  public int healthStatus;

  public Entity(string _name, string _role, int _healthMax, int _healthStatus)
  {
    name = _name;
    role = _role;
    healthMax = _healthMax;
    healthStatus = _healthStatus;
  }

}