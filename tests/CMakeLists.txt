add_executable(cpp_test test.cpp)

target_link_libraries(cpp_test PUBLIC 
GL 
glfw3 
X11 
pthread 
Xrandr 
Xi)

add_test(NAME test_opengl COMMAND $<TARGET_FILE>:cpp_test)