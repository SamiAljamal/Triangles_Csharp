using Nancy;
using Triangle.Objects;

namespace Triangles
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/form"] = _ => {
        return View["form.cshtml"];
      };
      Get["/triangle"] = _ => {
        TriangleVariables myTriangleVariables = new TriangleVariables();
        myTriangleVariables.SetSide1(Request.Query["side1"]);
        myTriangleVariables.SetSide2(Request.Query["side2"]);
        myTriangleVariables.SetSide3(Request.Query["side3"]);

        return View["triangle.cshtml", myTriangleVariables];


      };
    }
  }
}
