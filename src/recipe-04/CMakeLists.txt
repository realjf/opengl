set(SOURCE_FILES main.cpp ../glad.c)
add_executable(recipe-04 ${SOURCE_FILES})


target_link_libraries(recipe-04 
    PUBLIC 
    ${COMMON_LIBS})

