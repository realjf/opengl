set(SOURCE_FILES main.cpp glad.c)
add_executable(example ${SOURCE_FILES})

# add_subdirectory(renderer)

target_link_libraries(example 
    PUBLIC 
    ${COMMON_LIBS})

