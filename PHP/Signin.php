<?php require "Class.php";
    $message = "";
    $username_err = ""; 
    $password_err = "";
    $email_err = "";
    $name_err = "";
    $gender_err = "";
    function validationUserName($input){
        global $user;
        global $username_err;
        $contained = FALSE;
        foreach($user as $us){
            if($us->getUsername() === $input){
                $contained = TRUE;
                $username_err = "Username invaild! Try another!";
            } else {
                continue;
            }
        };
        if($contained){
            return "";
        } else {
            return $input;
        }
    };
    function validationMonth($month){
        global $message;
        $month_options = ["options" => ["min_range" => 1,"max_range" => 12]];
        if(filter_var($month,FILTER_VALIDATE_INT,$month_options)){
            return $month;
        } else {
            $message = "Wrong month!";
            return 1;
        };
    };
    function validationDay($day){
        global $message;
        $day_options = ["options" => ["min_range" => 1,"max_range" => 31]];
        if(filter_var($day,FILTER_VALIDATE_INT,$day_options)){
            return $day;
        } else {
            $message = "Wrong day!";
            return 1;
        };
    };
    function validationYear($year){
        global $message;
        $year_options = ["options" => ["min_range" => 1800,"max_range" => 2022]];
        if(filter_var($year,FILTER_VALIDATE_INT,$year_options)){
            return $year;
        } else {
            $message = "Wrong year";
            return 2022;
        };
    };
    function validationEmail($email){
        if(filter_var($email,FILTER_VALIDATE_EMAIL)){
            return trim(htmlspecialchars($email));
        }
    }
    if($_SERVER["REQUEST_METHOD"] == "POST"){
        $username= validationUserName($_POST["username"]);
        $password1 = $_POST["password1"];
        $password2 = $_POST["password2"];
        if($password1 != $password2){
            $message = "password are not match";
        } elseif(!filter_var($_POST["email"],FILTER_VALIDATE_EMAIL)){
            $message = "Email looks like wrong!";
        } else {
            $name = trim(htmlspecialchars($_POST["name"]));
            $day = validationDay($_POST["day"]);
            $month = validationDay($_POST["month"]);
            $year = validationDay($_POST["year"]);
            $email = validationEmail($_POST["email"]);
            $new_user = new User($name,$day,$month,$year,$_POST["gender"],$email,$username,$password1);
            $user[] = $new_user;
        }
        
    }