namespace Triangle.Objects
{
  public class TriangleVariables
  {
    private int _side1;
    private int _side2;
    private int _side3;

  public int GetSide1()
  {
    return _side1;
  }
  public void SetSide1(string newSide1)
  {
    _side1 = int.Parse(newSide1);
  }
  public int GetSide2()
  {
    return _side2;
  }
  public void SetSide2(string newSide2)
  {
    _side2 = int.Parse(newSide2);
  }
  public int GetSide3()
  {
    return _side3;
  }
  public void SetSide3(string newSide3)
  {
    _side3 = int.Parse(newSide3);
  }

  public bool IsTriangle()
  {
    bool nat1 = (_side1 + _side2 <= _side3);
    bool nat2 = (_side2 + _side3 <= _side1);
    bool nat3 = (_side1 + _side3 <= _side2);

    if (nat1 || nat2 || nat3)
    {
      return false;
    }
    else
    {
      return true;
    }
  }

  public string TriangleType()
  {
    if (IsTriangle() == true)
    {
      if (_side1 == _side2)
      {
        if (_side1 == _side3)
        {
          return "Equilateral";
        }
        else
        {
          return "Isoceles";
        }
      } else
      {
        if (_side1 == _side3)
        {
          return "Isoceles";
        }
        else
        {
          return "Scalene";
        }
      }
    }
    else
    {
      return "Not a ";
    }
  }
  }
}
