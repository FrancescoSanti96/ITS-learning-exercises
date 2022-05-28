<!DOCTYPE html>
<html lang="en">
<head>


    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Gestore Supereroi</title>


</head>
<body>

    <h1>Task For The Day</h1>

    <ul>
        <li>
            <strong>Name:</strong> <?= $task['title']; ?>
        </li>

        <li>
            <strong>Due date:</strong> <?= $task['due']; ?>
        </li>

        <li>
            <strong>Person responsible:</strong> <?= $task['assigned_to']; ?>
        </li>

        <li>
            <!-- Uso operatore php ternario condizionale -->
            <strong>Status:</strong> <?= $task['completed'] ? 'Complete' : 'Incomplete';?>
        </li>

        <li>
            <!-- Condizionale forma estesa -->
            <strong>Status:</strong>
            
            <?php

            if($task['completed']){
                echo 'finished';
            } else {
                echo 'Incomplete';
            }
            ?>
        </li>
    </ul>
</body>
</html>