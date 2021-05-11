include_directories( ${CMAKE_CURRENT_SOURCE_DIR} )

set(SOURCE_FILES main.cpp ../../glad.c)
add_executable(recipe-05 ${SOURCE_FILES})


target_link_libraries(recipe-05 
    PUBLIC 
    ${COMMON_LIBS})

