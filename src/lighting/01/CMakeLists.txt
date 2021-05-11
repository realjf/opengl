include_directories( ${CMAKE_CURRENT_SOURCE_DIR} )
set(SOURCE_FILES main.cpp ../../glad.c)
add_executable(01 ${SOURCE_FILES})


target_link_libraries(01
    PUBLIC 
    ${COMMON_LIBS})
