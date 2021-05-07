

add_executable(opengl1 main.cpp)

# add_subdirectory(renderer)

target_link_libraries(opengl1 
    PUBLIC 
    ${COMMON_LIBS})


