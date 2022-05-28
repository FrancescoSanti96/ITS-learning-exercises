<?php
$nome = "Francesco";
$sono = $nome . "Santi.";
echo $sono , '<BR>';
echo strlen($sono) , '<BR>';

$str2 = 'Hello World';
$str3 = strtolower($str2);
$str4 = strtoupper($str2);
echo '<BR>'.$str2;
echo '<BR>'.$str3;
echo '<BR>'.$str4;

$campione = " Chiesa ";
$campione2 = trim($campione);
echo '<BR>';
echo 'ciao' . $campione . 'calciatore','<BR>';
echo 'ciao' . $campione2 . 'calciatore','<BR>';

$str6 = '**Hello**World***';
echo trim($str6, '*') , '<br>';

$str7 = 'ABCDEF';
echo substr($str7, 2).'<BR>';
echo substr($str7, -3).'<BR>';
echo substr($str7, 2, 1) , '<BR>';
//Setta un preciso timezone
date_default_timezone_set('America/New_York');
echo date('D-M-Y', strtotime("+ 2 days")) , '<BR>';

$myArray = array(2, 5.1, 'PHP', 105);
var_dump($myArray);

$y = array('Nome' => 'Francesco');
var_dump($y);
$y['Cognome'] = 'Santi';
var_dump($y);
print_r($y);

array_splice($y,1);
print_r($y);

echo '<br>', array_search('Francesco', $y) , '<br>';
var_dump(array_search('Santi', $y));

$names1 = array(5 => "Peter", 24 => "Aaron");
$names2 = array(5 => "Zac", 4 => "Alfred", 7 =>
"Avi");
$newArray2 = array_merge($names1, $names2);
var_dump($newArray2);

$number1 = array(1,2,3);
$number2 = array(3,4,5);
$newNumber3 = array_merge($number1, $number2);
var_dump($newNumber3);