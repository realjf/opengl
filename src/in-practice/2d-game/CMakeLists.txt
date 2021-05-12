include_directories( ${CMAKE_CURRENT_SOURCE_DIR} )
set(SOURCE_FILES main.cpp ../../glad.c game.cpp resource_manager.cpp shader.cpp texture.cpp)
add_executable(2d-game ${SOURCE_FILES})


target_link_libraries(2d-game
    PUBLIC 
    ${COMMON_LIBS})