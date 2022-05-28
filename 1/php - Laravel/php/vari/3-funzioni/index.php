<?php
// Funzioni in php

$animals = ['dog', 'cat'];

// function die and dump the variable
function dd($data){
    echo '<pre>';
    die(var_dump($data));
    echo '</pre>';
}

// richiamo la funzione

dd('hello world');

require 'index.view.php';