<?php
$a = 11;

if ($a < 0)
    {
    echo 'if block<BR>';
    echo '$a is smaller than 0';
    }
elseif ($a < 5)
    echo 'First elseif block';
elseif ($a < 10)
    echo 'Second elseif block';
else
    echo 'Else block';

$b = 10;
switch ($b)
{
    case 10:
        echo 'Chocolate<BR>';
        break;
    case 20:
        echo 'Lemon<BR>';
    case 25:
        echo 'Strawberry<BR>';
        break;
    default:
        echo 'None of the above<BR>';
 }

 for ($c = 1; $c < 5; ++$c){
    echo '<br>The value of $c is ',$c,'<BR>';
    }

//foreach array associativo
$arr2 = array('Aaron'=>12, 'Ben'=>23, 'Carol'=>35);
foreach ($arr2 as $name=>$age){
    echo $name.' is '.$age.' years old.<BR>';
    }

?>
<?php
for($i=0; $i<5;++$i): ?>
    <h1>$i</h1>
    <?php endfor;
 
