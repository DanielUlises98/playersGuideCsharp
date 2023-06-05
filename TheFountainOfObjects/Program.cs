

using TheFountainOfObjects;
var sizeOfword = new SizeOfWorld(4,4);
var fountain = new PointInTheWorld(0, 2);
var entrance = new PointInTheWorld(0, 0);

World world = new World(sizeOfword,fountain,entrance);

Game game = new(world);

game.Start();