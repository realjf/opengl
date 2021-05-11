include_directories( ${CMAKE_CURRENT_SOURCE_DIR} )
set(SOURCE_FILES main.cpp ../../glad.c)
add_executable(02 ${SOURCE_FILES})


target_link_libraries(02
    PUBLIC 
    ${COMMON_LIBS})
