set(SOURCE_FILES main.cpp ../glad.c)
add_executable(recipe-02 ${SOURCE_FILES})


target_link_libraries(recipe-02 
    PUBLIC 
    ${COMMON_LIBS})

