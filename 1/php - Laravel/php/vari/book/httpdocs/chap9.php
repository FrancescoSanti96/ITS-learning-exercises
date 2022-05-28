<?php
include 'chap9movie.php';

$mov1 = new Movie('N0001', 'Lusso', 4.99);
var_dump($mov1);

$mov2 = new Movie('P0002', 'Junior', 5.99);
var_dump($mov2);

echo $mov1->title.'<BR>';
echo $mov1->conversion('Japan').'<BR>';

echo Movie::DISCOUNT.'<BR>';
echo $mov1::DISCOUNT.'<BR>';
echo $mov2::DISCOUNT.'<BR>';