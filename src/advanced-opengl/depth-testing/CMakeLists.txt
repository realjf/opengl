include_directories( ${CMAKE_CURRENT_SOURCE_DIR} )
set(SOURCE_FILES main.cpp ../../glad.c)
add_executable(depth-testing ${SOURCE_FILES})


target_link_libraries(depth-testing
    PUBLIC 
    ${COMMON_LIBS})