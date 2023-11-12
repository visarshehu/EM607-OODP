using BuilderPattern;

PancakeBuilder pancakeBuilder = new BlueberryPancakeBuilder();

PancakeDirector pancakeDirector = new PancakeDirector();



Pancake pancake = pancakeDirector.BuildPancake(pancakeBuilder);
pancake.ShowRecipe();
