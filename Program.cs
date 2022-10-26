using M2S5E1;
using M2S5E1.Enteties;

Dictionary<Resources, int> resource = new Dictionary<Resources, int>();
resource.Add(Resources.Mineral, 15);
resource.Add(Resources.Aliments, 05);
resource.Add(Resources.Materials, 30);

Dictionary<Resources, int> resource2 = new Dictionary<Resources, int>();
resource2.Add(Resources.Mineral, 51);
resource2.Add(Resources.Aliments, 50);
resource2.Add(Resources.Materials, 03);

var planet1 = new StarPlanets("Zezé DiCamargo Planet", 750, 951, 15, 1, resource);
var planet2 = new StarPlanets("Castelinho de Queijo Planet", 50, 7895, 50, 2, resource2);
var star = new Stars("João Pedro", 7542, 985462, 100, 15, 785, 100, StarClass.HyperGiant);


var gather = new StarGatherShip(ShipClass.StarGatherShip, 150, 150, 175, 250, 0);
var tavel = new StarBussShip(ShipClass.StarBussShip, 130, 130, 250, 50, planet1, planet2);

Console.WriteLine("\t\t Seja bem vindo a Demo de M2S5-E1(StarShip)\n"+
                  "Escolha uma nave\n1-Nave de Coleta de recursos\n2-Nave de viajem");
int parse;

if (!int.TryParse(Console.ReadLine(), out parse))
    parse = 0;
if(parse == 1)
{
    Console.WriteLine($"detectando um Corpo Celeste...\nEncontramos o Planeta:\n{planet1.Name}\nCondições para pouso é: {gather.Landing(planet1)}\nColetando recursos");
    gather.Collect(5);
    gather.Collect(5);
    gather.Collect(15);
    Console.WriteLine($"Coleta concluida\nCarga da nave {gather.CurrentCargo}/{gather.MaxCargo}\n");

    Console.WriteLine($"detectando um Corpo Celeste...\nEncontramos o Planeta:\n{planet2.Name}\nCondições para pouso é: {gather.Landing(planet2)}\nColetando recursos");
    gather.Collect(52);
    gather.Collect(50);
    gather.Collect(03);
    Console.WriteLine($"Coleta concluida\nCarga da nave {gather.CurrentCargo}/{gather.MaxCargo}\n");

    Console.WriteLine($"detectando um Corpo Celeste...\nEncontramos a Estrels: {star.Name}\nCondições para pouso é: {gather.Landing(star)}\nOrbitando: {gather.IsOrbting(star)}");

}
else if(parse == 2)
{ }
else
{
    Console.WriteLine("opção não existente o jogo sera fechado");
}