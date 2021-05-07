set(SOURCE_FILES main.cpp ../glad.c)
add_executable(recipe-03 ${SOURCE_FILES})


target_link_libraries(recipe-03 
    PUBLIC 
    ${COMMON_LIBS})

