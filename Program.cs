using Newtonsoft.Json;
using System.Collections.Generic;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/hello", () => HelloWorld());
app.MapGet("/addNums/{num1}/{num2}", (int num1, int num2) => AddNums(num1, num2));
app.MapPost("/postExample", () => PostExample());

app.MapGet("/showMotorcycle", () => showMotorcycle());
app.MapGet("/showMotorcycles", () => showMotorcycles());
app.MapPost("/createMotorcycle", (MotorcycleReq req) => createMotorcycle(req));

app.Run();

string HelloWorld() {
    return "Hello World!";
}

int AddNums(int n1, int n2) {
    return n1 + n2;
}

Motorcycle createMotorcycle(MotorcycleReq req) {
    Motorcycle newMc = new Motorcycle();
    newMc.Colour = req.Colour;
    newMc.Rego = "ABC-123";

    return newMc;
}

Motorcycle showMotorcycle() {
    Motorcycle m1 = new Motorcycle();
    m1.Rego = "TMP-AUS";
    m1.Colour = "Green";
    return m1;
}

List<Motorcycle> showMotorcycles() {
    Motorcycle m1 = new Motorcycle();
    m1.Rego = "TMP-AUS";
    m1.Colour = "Green";

    Motorcycle m2 = new Motorcycle();
    m2.Rego = "PMT-AUS";
    m2.Colour = "Red";

    List<Motorcycle> mcList = new List<Motorcycle>();
    mcList.Add(m1);
    mcList.Add(m2);

    return mcList;
}

string PostExample() {
    return "I was called using the Post method";
}