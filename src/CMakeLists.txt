add_executable(example main.cpp glad.c)

# add_subdirectory(renderer)

target_link_libraries(example 
    PUBLIC 
    ${COMMON_LIBS})

