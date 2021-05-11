include_directories( ${CMAKE_CURRENT_SOURCE_DIR} )
set(SOURCE_FILES main.cpp ../../glad.c)
add_executable(recipe-01 ${SOURCE_FILES})

# add_subdirectory(renderer)

target_link_libraries(recipe-01 
    PUBLIC 
    ${COMMON_LIBS})
