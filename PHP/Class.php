<?php
    class User {
        private $user_name, $user_age, $day_of_birth, $gender, $email, $username, $u_password;
        function __construct($name, $day, $month, $year,$gender,$email, $username, $password)
        {
            $this->user_name = $name;
            $this->day_of_birth = $month."/".$day."/".$year;
            $this->gender = $gender;
            $this->email = $email;
            $this->user_age = date("Y") - $year;
            $this->username = $username;
            $this->u_password = $password;
        }
        public function getName(){
            return $this->user_name;
        }
        public function getAge(){
            return $this->user_age;
        }
        public function getBirthday(){
            return $this->day_of_birth;
        }
        public function getGender(){
            return $this->gender;
        }
        public function getUsername(){
            return $this->username;
        }
        public function getInfo(){
            return "User name: {$this->user_name}\n Age: {$this->user_age}\nBOD: {$this->day_of_birth}\nGender: {$this->gender}\nEmail: {$this->email}.\n";
        }
    }
    $admin = new User("admin",1,1,2022,"female","admin@gmail.com","admin","123456");
    $user = [$admin];