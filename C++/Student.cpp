#include <iostream>

class Student{
	std::string _name;
	int _age;
	const std::string _rollno;
	public:
		Student(std::string name = "Guest", int age = 18)
			: _rollno("stu44"), _name(name), _age(age) {}
	void getInfo() {
		std::cout<<"\n Student: "<<_name<<"\t Age: "<<_age<<"\nRollNo: "<<_rollno<<"\n";
	}
	//Destructor
	~Student(){
		std::cout << "Deleted strudent "<<_name<<"\n";
	}
};

int main(){
	//Student default_stu();
	Student st1("Coffee", 22);
	Student st2("Black");
	Student st3("A",23);
	//default_stu.getInfo();
	st1.getInfo();
	st2.getInfo();
	st3.getInfo();
	return 0;
}
