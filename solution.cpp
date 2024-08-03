Here is a simple implementation of a JSON.stringify function in C++ using the nlohmann/json library. This library provides a simple and intuitive way to handle JSON data in C++. 

```cpp
#include <iostream>
#include <nlohmann/json.hpp>

std::string stringify(nlohmann::json j) {
    return j.dump();
}

int main() {
    nlohmann::json j;
    j["name"] = "John";
    j["age"] = 30;
    j["city"] = "New York";

    std::cout << stringify(j) << std::endl;

    return 0;
}
```

This program creates a JSON object, adds some data to it, and then uses the `dump` function from the nlohmann/json library to convert the JSON object to a string. The `dump` function is equivalent to the `JSON.stringify` function in JavaScript. 

Please note that you need to have the nlohmann/json library installed to run this program. You can install it using vcpkg or download it directly from the GitHub repository.