<?php
//operatore ternario
//true ? 'do something' : 'do something else'
//<strong>Stutus:</strong> <?= $task['completed'] ? 'Complete' : 'Incomplete';

$task = [
    'title' => 'Finish homework',
    'due' => 'today',
    'assigned_to' => 'Fra',
    'completed' => true
];

require 'index.view.php';