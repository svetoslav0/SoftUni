<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 06-Oct-18
 * Time: 7:07 PM
 */

class Trainer{
    public $name;
    public $numberOfBadges = 0;
    public $pokemons = array();

    /**
     * @return array
     */
    public function getPokemons(): array
    {
        return $this->pokemons;
    }

    /**
     * Trainer constructor.
     * @param $name
     * @param int $numberOfBadges
     * @param array $pokemons
     */
    public function __construct($name, int $numberOfBadges, array $pokemons)
    {
        $this->name = $name;
        $this->numberOfBadges = $numberOfBadges;
        $this->pokemons = $pokemons;
    }

}
class Pokemon{
    public $name;
    public $element;
    public $health;

    /**
     * @return mixed
     */
    public function getHealth()
    {
        return $this->health;
    }

    /**
     * @param mixed $health
     */
    public function setHealth($health): void
    {
        $this->health = $health;
    }

    /**
     * Pokemon constructor.
     * @param $name
     * @param $element
     * @param $health
     */
    public function __construct($name, $element, $health)
    {
        $this->name = $name;
        $this->element = $element;
        $this->health = $health;
    }

}

$trainers = [];
$pokemons = [];

$line = readline();
while($line != 'Tournament') {


    list($trainerName, $pokemonName, $pokemonElement, $pokemonHealth) = explode(' ', $line);

    $currentPokemon = new Pokemon($pokemonName, $pokemonElement, $pokemonHealth);
    $pokemons[] = $currentPokemon;

    $hasTrainer = false;
    foreach ($trainers as $trainer) {
        if ($trainer->name == $trainerName) {
            $hasTrainer = true;
            break;
        }
    }
    unset($trainer);

    if (!$hasTrainer) {
        $currentTrainer = new Trainer($trainerName, 0, [$pokemonName]);
        $trainers[] = $currentTrainer;
        unset($currentTrainer);
    } else {
        $searchedTrainer = null;
        foreach ($trainers as $trainer) {
            if ($trainerName == $trainer->name) {
                $searchedTrainer = $trainer;
                break;
            }
        }
        $index = array_search($searchedTrainer, $trainers);
        $trainers[$index]->pokemons[] = $pokemonName;
    }
    $line = readline();
}


$currentElement = readline();
while ($currentElement != 'End'){ // currentElement = Fire (for ex)
    foreach ($trainers as $trainer) { // trainers -> array of all trainers, trainer -> each one of the trainers
        $currentTrainerPokemons = $trainer->getPokemons(); // array of all pokemons that the current trainer owns
        foreach ($currentTrainerPokemons as $currentPokemon) { // currentPokemon -> each one of these pokemons
            $foundElement = null;
            foreach ($pokemons as $pokemon) { // pokemons -> array of all pokemons, pokemon (obj) -> each one of them
                if ($pokemon->name == $currentPokemon) {
                    $foundElement = $pokemon->element;
                }
            }
            if ($foundElement == $currentElement) { // if the element was found as property of at least one
                $trainer->numberOfBadges++;        // of the pokemons that the trainer owns, he gets a badge
                break;
            } else {
                // if not, remove 10 health of each pokemons that the trainer owns
                foreach ($pokemons as $pokemon) {
                    $currentName = $pokemon->name;
                    if ($currentName == $currentPokemon) {
                        $pokemon->health -= 10;
                        if ($pokemon->health <= 0){
                            $index = array_search($pokemon, $pokemons);
                            unset($pokemons[$index]);
                            $pokemonToRemove = $pokemon->name;

                            foreach ($trainers as $innerTrainer) {
                                foreach ($innerTrainer->pokemons as $searchedPokemon) {
                                    if ($searchedPokemon == $pokemonToRemove){
                                        $index = array_search($pokemonToRemove, $innerTrainer->pokemons);
                                        unset($innerTrainer->pokemons[$index]);
                                    }
                                }
                            }
                        }
                        break;

                    }
                }
            }
        }

    }
    $currentElement = readline();
}

usort($trainers, function(Trainer $a, Trainer $b){
   return $b->numberOfBadges <=> $a->numberOfBadges;
});


foreach ($trainers as $trainer) {
    $trainerName = $trainer->name;
    $trainerBadges = $trainer->numberOfBadges;
    $trainerPokemons = count($trainer->pokemons);
    echo "$trainerName $trainerBadges $trainerPokemons" . PHP_EOL;
}

