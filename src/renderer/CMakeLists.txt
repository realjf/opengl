add_library(renderer "")

target_sources(renderer PUBLIC ${CMAKE_CURRENT_LIST_DIR}/renderer.hpp)


target_include_directories(renderer PUBLIC ${CMAKE_CURRENT_LIST_DIR})
