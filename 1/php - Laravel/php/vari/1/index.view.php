<!DOCTYPE html>
<html lang="en">
<head>


    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Gestore Supereroi</title>


</head>
<body>
    <h1>Lista superoi</h1>

    <ul>
    <?php
        //mostra l'array a video
            foreach($supereroi as $name){
                echo "<li>$name</li>";
            }
        ?>

    </ul>





    <h1>Lista superoi con le loro qualità</h1>

    <ul>
        <?php foreach($supereroi2 as $nome => $qualita) : ?>
            
            <li><strong><?= $nome; ?></strong> <?= $qualita; ?></li>

        <?php endforeach; ?>
    </ul>

    <h3>Inserire del testo</h3>
    <input type="text">
</body>
</html>