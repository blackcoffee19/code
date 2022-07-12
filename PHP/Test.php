<?php
    require "Class.php";
    echo "Create new user: \n";
    echo "What's your name? ";
    $name = readline(">> ");
    echo "\nWhat's your day of birth? ";
    $day = readline(">> ");
    echo "\n What's your month of birth? ";
    $month = readline(">> ");
    echo "\n What's year you was born? ";
    $year = readline(">> ");
    echo "\n What's your gender? ";
    $gender = readline(">> ");
    echo "\n Your email is: ";
    $email = readline(">> ");
    $user = new User($name,$day,$month,$year, $gender, $email);
    echo $user->getInfo();