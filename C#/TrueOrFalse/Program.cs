
// Type your code below
string[] questions = {"1. DDos stand for \"Denial of Service\"", "2.TCP stand for \"Transmission Control Protocol\"","3. 192.168.1.7 is a private IP address (Internet Protocol)", "4. MAC address can be faked or \"spoofed\" (spoofing)", "5. 2 devices use their private IP addresses to communicate with each other. But any data sent to the Internet from either of these devices will be identified by the same public IP address", "6. 86.157.52.21 is a public IP address","7. Switches are dedicated devices within a network that are designed to aggregate multiple other devices such as computers, printers, or any other networking-capable device using ethernet.", "8. Router\'s job to connect networks and pass data between them. It does this by using routing" ,"9. ARP(Address Resolution Protocol) request is sent, a message is broadcasted to every other device found on a network by the device, asking whether or not the device\'s MAC address matches the requested IP address.", "10. If the device does have the requested IP address, an ARP reply is returned to the initial device to acknowledge this. The initial device will now remember this and store it within its cache (an ARP entry).", "11. DHCP stands for Dynamic Host Configuration Protocol"};
bool[] answers = {true,true,true, true,true,true,true,true,true,true,true};
bool[] responses = new bool[questions.Length];
int askingIndex = 0;
foreach(string ques in questions) {
  string? input;
  bool isBool, inputBool;
  Console.WriteLine(ques);
  Console.WriteLine("True or False?");
  input = Console.ReadLine();
  isBool = Boolean.TryParse(input, out inputBool);
  while(!isBool) {
    Console.WriteLine("Please respond with \'true\' or \'false\'.");
    input = Console.ReadLine();
    isBool = Boolean.TryParse(input, out inputBool);
  };
  responses[askingIndex] = inputBool;
  askingIndex++;
}
//Console.WriteLine(string.Join(" ", responses));
int scoringIndex = 0;
int score = 0;
foreach(bool answer in answers) {
    Console.WriteLine($"{scoringIndex +1}. Your answer: {responses[scoringIndex]} | Answer: {answer}.");
    if(answer == responses[scoringIndex]) {
        score++;
    };
    scoringIndex++;
};
Console.WriteLine($"You got {score} out of {answers.Length} correct!");