<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8">
        <title>PHP</title>
        <link rel="stylesheet" type="text/css" href="style.css"/>
    </head>
    <body bgcolor="#06283D">
        <header height="20%">
            <div id="logo">
                <h1>My PHP page</h1>
            </div>
        </header>
        <main height="70%">
            <div class="form">
                <?php require "Class.php";
                    $message = "";
                    $validation_error = "your password is incorrect!";
                    function validationUserName($input){
                        global $user;
                        global $message;
                        $contained = FALSE;
                        foreach($user as $us){
                            if($us->getUsername() === $input){
                                $contained = TRUE;
                                $message = "Username invaild! Try another!";
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
                ?>
                <table>
                    <tr>
                        <th><span><?=$message?></span></th>
                    </tr>
                <form method="post">
                    <tr>
                        <td><h2>Username:</h2></td>
                        <td><input type="text" name="username" value="<?=$username?>"></td>
                    <tr> 
                    <tr>
                        <td><h2>Password:</h2></td>
                        <td><input type="password" name="password1"></td>
                    </tr>
                    <tr>
                        <td><h2>Rewrite password:</h2></td>
                        <td><input type="password" name="password2"></td>
                    </tr>
                    <tr>
                        <td><h2>Email:</h2></td>
                        <td><input type="text" name="email" value="<?=$email?>"></td>
                    </tr>
                    <tr>
                        <td><h2>Name:</h2></td>
                        <td><input type="text" name="name" value="<?=$name?>"></td>
                    </tr>
                    <tr>
                        <td><h2>Gender:</h2></td>
                        <td><input type="radio" name="gender" value="female"> Female &nbsp; <input type="radio" name="gender" value="male"> Male</td>
                    </tr>
                    <tr>
                        <td><h2>Day: </h2></td>
                        <td><input type="number" name="day" value="<?=$day?>"></td>
                    </tr>
                    <tr>
                        <td><h2>Month: </h2></td>
                        <td><input type="number" name="month" value="<?=$month?>"></td>
                    </tr>
                    <tr>
                        <td><h2>Year: </h2></td>
                        <td><input type="number" name="year" value="<?=$year?>"></td>
                    </tr>
                    <tr>
                        <td cols="2">
                            <center><input type="submit" value="Logins"></center>
                        </td>
                    </tr>
                </form>
                </table>
                <a href="index.php">Reset</a>
            </div>
            <div class="profie">
                <button onclick="hideAndShow()">Show</button>
                <div id="output">
                    <p>Name : <?=$new_user->getName()?></p>
                    <p>Gender: <?=$new_user->getGender()?></p>
                    <p>Birthday: <?=$new_user->getBirthday()?></p>
                </div>
            </div>        
        </main>
        <footer height="10%"></footer>
        <script>
            function hideAndShow(){
                if(document.getElementById("output").style.display = "block"){
                    document.getElementById("output").style.display = "none";
                }else{
                    document.getElementById("output").style.display = "block";
                };
            }
        </script>
    </body>
</html>