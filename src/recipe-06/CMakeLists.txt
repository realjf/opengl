include_directories( ${CMAKE_CURRENT_SOURCE_DIR} )

set(SOURCE_FILES main.cpp ../glad.c)
add_executable(recipe-06 ${SOURCE_FILES})


target_link_libraries(recipe-06 
    PUBLIC 
    ${COMMON_LIBS})

